using Microsoft.EntityFrameworkCore;
using Shop.Services.ProductAPI.Models;

namespace Shop.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        DbSet<Product> Products { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
        DbSet<ProductVideo> ProductVideos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            for (int i = 1; i <= 6; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        ProductId = i,
                        ProductName = $"Product {i}",
                        Slug = $"product-{i}",
                        Description = $"Description for Product {i}",
                        Size = "Large",
                        Color = "Red",
                        Price = 19.99m,
                        Quantity = i+00,
                        SoldQuantity = 0,
                        CategoryId = i,
                        BrandId = i,
                        MetaTitle = $"Meta Title for Product {i}",
                        MetaDescription = $"Meta Description for Product {i}"
                    },
                    new ProductImage
                    {
                        ImageId = i,
                        ProductId = i,
                        ImageUrl = "https://placehold.co/603x403"
                    }
                );
            }
        }
    }
}
