using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Data.Models;

namespace Data.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Sku).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
        builder.Property(p => p.Price).HasColumnType("numeric(18,2)");
        builder.HasIndex(p => p.Sku).IsUnique();

        var staticDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        var initialProducts = Enumerable.Range(1, 100).Select(i => new Product
        {
            Id = i,
            Sku = $"SKU-{i:00000}",
            Name = $"Demo Product {i}",
            Price = 99.99m + i,
            StockQuantity = 1000,
            CreatedAt = staticDate
        });

        builder.HasData(initialProducts);
    }
}