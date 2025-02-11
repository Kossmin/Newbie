using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProductService.Models
{
    public class ProductContext(DbContextOptions<ProductContext> options, IConfiguration configuration)
        : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
