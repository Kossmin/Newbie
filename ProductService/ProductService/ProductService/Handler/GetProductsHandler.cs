using System.Reflection.Metadata;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductService.Handler;

public class GetProductsHandler 
{
    readonly IProductRepository _productRepository;

    public GetProductsHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> Handle()
    {
        return await _productRepository.GetProducts();
    }
}