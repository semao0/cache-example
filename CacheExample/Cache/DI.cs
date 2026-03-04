using Microsoft.Extensions.Caching.Hybrid;
using StackExchange.Redis;

namespace Cache;

public static class DependencyInjection
{
    public static IServiceCollection AddCaching(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        var redisConnectionString = configuration.GetConnectionString("Redis");
        if (string.IsNullOrEmpty(redisConnectionString))
            throw new InvalidOperationException("Redis connection string is missing.");

        var cacheSettings = new CacheSettings();
        configuration.GetSection(CacheSettings.SectionName).Bind(cacheSettings);

        var multiplexer = ConnectionMultiplexer.Connect(redisConnectionString);
        services.AddSingleton<IConnectionMultiplexer>(multiplexer);

        services.AddStackExchangeRedisCache(options => 
        {
            options.ConnectionMultiplexerFactory = () => Task.FromResult<IConnectionMultiplexer>(multiplexer);
        });

        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = redisConnectionString;
            options.InstanceName = "DemoApp_";
        });

        services.AddHybridCache(options =>
        {
            options.DefaultEntryOptions = new HybridCacheEntryOptions
            {
                LocalCacheExpiration = TimeSpan.FromMinutes(cacheSettings.LocalExpirationMinutes),
                Expiration = TimeSpan.FromMinutes(cacheSettings.DistributedExpirationMinutes)
            };
        });

        services.AddSingleton<CacheService>();

        return services;
    }
}