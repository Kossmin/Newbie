using MessagingAPI;
using Moq;
using ProductService.Handler;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductServicesTest;

public class CreateProductHandlerTest
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly CreateProductHandler _createProductHandler;

    public CreateProductHandlerTest()
    {
        _mockProductRepository = new Mock<IProductRepository>();
        _createProductHandler = new CreateProductHandler(_mockProductRepository.Object);
    }

    [Fact]
    public async Task CreatesProduct_Return_Product()
    {
        _mockProductRepository.Setup(x => x.CreateProduct(It.IsAny<Product>()));

        var request = new CreateProductRequest()
        {
            ProductName = "Test Product",
            Description = "Test Description",
            Active = true,
            Price = 10
        };
        var result = _createProductHandler.CreateProductAsync(request);
        
        Assert.Equal(request.ProductName, result.Result.ProductName);
    }
}