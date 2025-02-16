using MessagingAPI;
using Moq;
using ProductService.Handler;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductServicesTest;

public class UpdateProductHandlerTest
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly UpdateProductHandler _updateProductHandler;

    public UpdateProductHandlerTest()
    {
        _mockProductRepository = new Mock<IProductRepository>();
        _updateProductHandler = new UpdateProductHandler(_mockProductRepository.Object);
    }

    [Fact]
    public async Task UpdateProduct_Success()
    {
        var updateRequest = new UpdateProductRequest()
        {
            ProductId = 1,
            ProductName = "Test Product",
        };
        
        _mockProductRepository.Setup(repo => repo.UpdateProduct(It.IsAny<Product>()))
            .ReturnsAsync(new Product(){ProductId = 1});
        
        var succes = await _updateProductHandler.UpdateProductAsync(updateRequest);
        
        Assert.NotNull(succes);
    }

    [Fact]
    public async Task UpdateProduct_Failure_WithWrongId()
    {
        var product = new Product()
        {
            ProductId = 1
        };
        var updateRequest = new UpdateProductRequest()
        {
            ProductId = 2
        };
        
        _mockProductRepository.Setup(repo => repo.UpdateProduct(product))
            .ThrowsAsync(new KeyNotFoundException());
        
        await Assert.ThrowsAsync<KeyNotFoundException>(() => _updateProductHandler.UpdateProductAsync(updateRequest));
    }
    
}