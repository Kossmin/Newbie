using MessagingAPI;
using Moq;
using ProductService.Handler;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductServicesTest;

public class DeleteProductHandlerTest
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly DeleteProductHandler _deleteProductHandler;

    public DeleteProductHandlerTest()
    {
        _mockProductRepository = new Mock<IProductRepository>();
        _deleteProductHandler = new DeleteProductHandler(_mockProductRepository.Object);
    }


    [Fact]
    public async Task DeleteProduct_Success()
    {
        var deleteProduct = new Product()
        {
            ProductId = 1,
            ProductName = "Test Product",
            Description = "Test Description",
            CategoryId = 1,
            Price = 10,
            ThumbnailImageUrl = "imageUrl.jpg", 
            Active = true
        };

        var deleteRequest = new DeleteProductRequest()
        {
            ProductId = deleteProduct.ProductId,
        };
        
        _mockProductRepository.Setup(x => x.DeleteProduct(deleteProduct.ProductId)).ReturnsAsync(deleteProduct);
        
        var result =  await _deleteProductHandler.DeleteProductAsync(deleteRequest);
        
        Assert.NotNull(result);
        Assert.True(deleteProduct.ProductId == deleteRequest.ProductId);
    }

    [Fact]
    public async Task DeleteProduct_Failed()
    {
        var productId = 1;

        var deleteRequest = new DeleteProductRequest()
        {
            ProductId = productId,
        };
        
        _mockProductRepository.Setup(x => x.DeleteProduct(productId)).ReturnsAsync((Product)null);
        
        await Assert.ThrowsAsync<Exception>(()=> _deleteProductHandler.DeleteProductAsync(deleteRequest));
        
    }
}