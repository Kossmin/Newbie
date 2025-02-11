using MessagingAPI;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductService.Handler;

public class GetProductByIdHandler
{
    readonly IProductRepository _productRepository;
    
    public GetProductByIdHandler()
    {
        _productRepository = new ProductRepository(new ProductContext());
    }

    public async Task<Product> GetProductByIdAsync(GetProductByIdRequest request)
    {
        int productId = request.ProductId;
        return await _productRepository.GetProductById(productId);
    }
}