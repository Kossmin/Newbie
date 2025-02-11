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
            modelBuilder.Entity<Category>().HasData(FakeCategoryGenerator.GenerateCategories(5));
            modelBuilder.Entity<Product>().HasData(FakeProductGenerator.GenerateProducts(10));
            base.OnModelCreating(modelBuilder);
        }
    }
}
