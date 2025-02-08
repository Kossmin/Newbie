using Microsoft.EntityFrameworkCore;

namespace ProductService.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost,3306;Database=ProductDatabase;user=root;Password=;TrustServerCertificate=True";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            
        }
    }
}
