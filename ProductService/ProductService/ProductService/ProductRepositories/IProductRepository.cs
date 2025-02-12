using ProductService.Models;

namespace ProductService.IProductRepositories;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetProducts();
    
    public Task<Product> GetProductById(int id);
    
    public Task<Product> CreateProduct(Product product);
    
    public Task<Product> UpdateProduct(Product product);
    
    public Task<Product> DeleteProduct(int id);
}