using ProductService.Models;

namespace ProductService.IProductRepositories;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetProducts();
}