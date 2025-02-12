using MessagingAPI;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductService.Handler;

public class GetProductByIdHandler
{
    readonly IProductRepository _productRepository;
    
    public GetProductByIdHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> GetProductByIdAsync(GetProductByIdRequest request)
    {
        var productId = request.ProductId;
        
        var product = await _productRepository.GetProductById(productId);
        
        if (product == null)
        {
            throw new KeyNotFoundException("Product not found");
        }
        
        return product;
    }
}