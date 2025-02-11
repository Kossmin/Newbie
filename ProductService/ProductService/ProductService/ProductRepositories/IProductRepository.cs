using ProductService.Models;

namespace ProductService.IProductRepositories;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetProducts();
    
    public Task<Product> GetProductById(int id);
}