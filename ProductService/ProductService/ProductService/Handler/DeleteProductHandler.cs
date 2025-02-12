using MessagingAPI;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductService.Handler;

public class DeleteProductHandler(IProductRepository productRepository)
{
    public async Task<Product> DeleteProductAsync(DeleteProductRequest request)
    {
        var deleteProduct = await productRepository.DeleteProduct(request.ProductId);
        if (deleteProduct == null)
        {
            throw new Exception($"Product with id {request} not found");
        }
        return deleteProduct;
    }
}