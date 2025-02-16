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
    public async Task CreatesProduct_WithValidData_ShouldReturnTrue()
    {
        
        var request = new CreateProductRequest
        {
            ProductName = "Laptop",
            CategoryId = 1,
            ShortDesc = "Gaming Laptop",
            Description = "High-end gaming laptop",
            Price = 1500,
            ThumbnailImageUrl = "image.jpg",
            UnitsInStock = 10
        };

        var createdProduct = new Product
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
        
        _mockProductRepository.Setup(x => x.CategoryExists(request.CategoryId)).ReturnsAsync(true);
        _mockProductRepository.Setup(x => x.CreateProduct(It.IsAny<Product>())).ReturnsAsync(createdProduct);
        
        var result = await _createProductHandler.CreateProductAsync(request);
        
        Assert.NotNull(result);
        Assert.Equal(request.ProductName, result.ProductName);
    }

    [Fact]
    public async Task CreatesProduct_WithoutProductName_ShouldReturnNull()
    {
        var requestCreate = new CreateProductRequest()
        {
            CategoryId = 1,
            ShortDesc = "Gaming Laptop",
            Description = "High-end gaming laptop",
            Price = 1500,
            Active = true
        };

        _mockProductRepository.Setup(x => x.CategoryExists(1));
        await Assert.ThrowsAsync<ArgumentException>(() => _createProductHandler.CreateProductAsync(requestCreate));
    }

    [Fact]
    public async Task CreateProduct_WithDuplicated_Product()
    {
        var request = new CreateProductRequest()
        {
            ProductName = "Laptop",
            CategoryId = 1
        };
        
        _mockProductRepository.Setup(x => x.CategoryExists(request.CategoryId)).ReturnsAsync(true);

        _mockProductRepository.Setup(x => x.ProductExists(request.ProductName, request.CategoryId))
            .ReturnsAsync(true);
        
        await Assert.ThrowsAsync<ArgumentException>(() => _createProductHandler.CreateProductAsync(request));
    }

    [Fact]
    public async Task CreateProduct_WithNoCategory_Return_Error()
    {
        var request = new CreateProductRequest()
        {
            ProductName = "Laptop",
            ShortDesc = "Gaming Laptop",
            Description = "High-end gaming laptop",
            Price = 1500,
            ThumbnailImageUrl = "image.jpg",
            UnitsInStock = 10
        };
        
        _mockProductRepository.Setup(x => x.CreateProduct(It.IsAny<Product>())).ThrowsAsync(new ArgumentException("Product not have Category Id."));
        
        await Assert.ThrowsAsync<ArgumentException>(() => _createProductHandler.CreateProductAsync(request));
    }
}