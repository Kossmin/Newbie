using MessagingAPI;
using Moq;
using ProductService.Handler;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductServicesTest;

public class GetProductByIdHandlerTest
{
    private readonly  Mock<IProductRepository> _mockProductRepository;
    private readonly GetProductByIdHandler _getProductsByIdHandler;
    public GetProductByIdHandlerTest()
    {
        _mockProductRepository = new Mock<IProductRepository>();
        _getProductsByIdHandler = new GetProductByIdHandler(_mockProductRepository.Object);
    }
    
    [Fact]
    public async Task GetProductById_Returns_Product()
    {
        var product = new Product()
        {
            ProductId = 1,
            ProductName = "Test Product",
            Active = false,
            Price = 10
        };
        _mockProductRepository.Setup(x => x.GetProductById(product.ProductId))
            .ReturnsAsync(product);
        var request = new GetProductByIdRequest()
        {
            ProductId = product.ProductId
        };
        var result = await _getProductsByIdHandler.GetProductByIdAsync(request);
        
        Assert.Equal(product, result);
    }

    [Fact]
    public async Task GetProductById_Returns_Null()
    {
        var request = new GetProductByIdRequest()
        {
            ProductId = -1
        };
        
         await Assert.ThrowsAsync<KeyNotFoundException>(()=>  _getProductsByIdHandler.GetProductByIdAsync(request));
    }

    [Fact]
    public async Task GetProductById_Returns_Exception()
    {
        _mockProductRepository.Setup(x => x.GetProductById(1))
            .ThrowsAsync(new Exception("Error"));
        
        var request = new GetProductByIdRequest()
        {
            ProductId = 1
        };

        await Assert.ThrowsAsync<Exception>(() => _getProductsByIdHandler.GetProductByIdAsync(request));
    }
    
}