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
        var products =  await _productRepository.GetProducts();
        
        if (products == null)
        {
            throw new KeyNotFoundException("List of products is empty");
        }
        return products;
    }
}