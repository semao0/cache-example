using Cache;
using Data.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Hybrid;
using System.Text.Json;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _appDbContext;
    private readonly IDistributedCache _redisCache;
    private readonly CacheService _hybridCache;

    public ProductsController(IDistributedCache redisCache, CacheService hybridCache, AppDbContext appDbContext)
    {
        _redisCache = redisCache;
        _hybridCache = hybridCache;
        _appDbContext = appDbContext;
    }
    private async Task<Product?> GetProductFromDbAsync(int id)
    {
        var query = @"
            SELECT p.* FROM ""Products"" p
            CROSS JOIN generate_series(1, 50000) AS g
            WHERE p.""Id"" = {0}
            ORDER BY MD5(p.""Name"" || g::text)
            LIMIT 1";

        return await _appDbContext.Products
            .FromSqlRaw(query, id)
            .FirstOrDefaultAsync();
    }

    [HttpGet("{id}/nocache")]
    public async Task<IActionResult> GetNoCache(int id)
    {
        var data = await GetProductFromDbAsync(id);
        return Ok(new { Id = id, Data = data, Source = "Database" });
    }

    // 2. ТОЛЬКО REDIS (L2 - Distributed Cache)
    [HttpGet("{id}/redis")]
    public async Task<IActionResult> GetRedisOnly(int id)
    {
        var cacheKey = $"product_redis_{id}";
        var cachedBytes = await _redisCache.GetAsync(cacheKey);

        if (cachedBytes != null)
        {
            var cachedData = JsonSerializer.Deserialize<string>(cachedBytes);
            return Ok(new { Id = id, Data = cachedData, Source = "Redis L2" });
        }

        // Cache-Aside
        var dbData = await GetProductFromDbAsync(id);
        var options = new DistributedCacheEntryOptions { AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5) };
        await _redisCache.SetAsync(cacheKey, JsonSerializer.SerializeToUtf8Bytes(dbData), options);

        return Ok(new { Id = id, Data = dbData, Source = "Database" });
    }

    // 3. HYBRID CACHE (L1 In-Memory + L2 Redis)
    [HttpGet("{id}/hybrid")]
    public async Task<IActionResult> GetHybrid(int id, CancellationToken cancellationToken)
    {
        var cacheKey = $"product_hybrid_{id}";

        // HybridCache сам защищает от Cache Stampede и координирует L1/L2
        var data = await _hybridCache.GetOrCreateAsync(
            cacheKey,
            async cancel => await GetProductFromDbAsync(id),
            cancellationToken: cancellationToken
        );

        return Ok(new { Id = id, Data = data, Source = "Hybrid L1+L2" });
    }
}