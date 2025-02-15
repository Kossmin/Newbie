using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductService.DataGenerators;

namespace ProductService.Models
{
    public class ProductContext(DbContextOptions<ProductContext> options, IConfiguration configuration)
        : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            base.OnConfiguring(optionsBuilder);
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CatName = "Electronics", Description = "Gadgets and devices" },
                new Category { Id = 2, CatName = "Clothing", Description = "Apparel and accessories" },
                new Category { Id = 3, CatName = "Books", Description = "Fiction and non-fiction" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Laptop", CategoryId = 1 },
                new Product { ProductId = 2, ProductName = "T-Shirt", CategoryId = 2 },
                new Product { ProductId = 3, ProductName = "Novel", CategoryId = 3 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
