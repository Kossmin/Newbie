using MessagingAPI;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductService.Handler;

public class UpdateProductHandler(IProductRepository productRepository)
{
    public async Task<Product> UpdateProductAsync(UpdateProductRequest request)
    {
        
        var updateRequest = new Product
        {
            ProductId = request.ProductId,
            ProductName = request.ProductName,
            CategoryId = request.CategoryId,
            ShortDesc = request.ShortDesc,
            Description = request.Description,
            Price = request.Price,
            ThumbnailImageUrl = request.ThumbnailImageUrl,
            Active = request.Active,
            UnitsInStock = request.UnitsInStock
        };
        
        var updateProduct =  await productRepository.UpdateProduct(updateRequest);

        if (updateProduct == null)
        {
            throw new KeyNotFoundException($"Product not found with id {request.ProductId}");
        }
        
        return updateProduct;
    }
}