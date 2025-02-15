using MessagingAPI;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductService.Handler;

public class CreateProductHandler(IProductRepository productRepository)
{
    public async Task<Product> CreateProductAsync(CreateProductRequest request)
    {
        if (string.IsNullOrEmpty(request.ProductName))
        {
            throw new ArgumentException("Product name is required");
        }

        if (request.CategoryId <= 0)
        {
            throw new ArgumentException("Category Id is required");
        }
        
        // Check the Cat ID exist ? How ? 
        var categoryExists = await productRepository.CategoryExists(request.CategoryId);
        if (!categoryExists)
        {
            throw new ArgumentException($"Category with ID {request.CategoryId} does not exist.");
        }
        
        var product = new Product
        {
            ProductName = request.ProductName,
            CategoryId = request.CategoryId,
            ShortDesc = request.ShortDesc,
            Description = request.Description,
            Price = request.Price,
            ThumbnailImageUrl = request.ThumbnailImageUrl,
            DateCreated = DateTime.UtcNow,
            Active = true,
            UnitsInStock = request.UnitsInStock
        };
        
        var createProduct = await productRepository.CreateProduct(product);
        
        return createProduct;
    }
}