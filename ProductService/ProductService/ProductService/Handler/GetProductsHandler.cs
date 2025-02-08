using System.Reflection.Metadata;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductService.Handler;

public class GetProductsHandler 
{
    readonly IProductRepository _productRepository;

    public GetProductsHandler()
    {
        _productRepository = new ProductRepository(new ProductContext());
    }

    public async Task<IEnumerable<Product>> Handle()
    {
        return await _productRepository.GetProducts();
    }
}