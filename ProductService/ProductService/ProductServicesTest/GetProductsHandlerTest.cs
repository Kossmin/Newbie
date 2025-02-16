using Moq;
using ProductService.Handler;
using ProductService.IProductRepositories;
using ProductService.Models;

namespace ProductServicesTest;

public class GetProductsHandlerTest
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly GetProductsHandler _getProductsHandler;

    public GetProductsHandlerTest()
    {
        _mockProductRepository = new Mock<IProductRepository>();
        _getProductsHandler = new GetProductsHandler(_mockProductRepository.Object);
    }

    [Fact]
    public async Task GetProducts_ReturnsProducts()
    {
        var productList = new List<Product>()
        {
            new Product()
            {
                ProductId = 1,CategoryId = 1,ProductName = "Product1",Price = 10,Active = true
            },
            new Product()
            {
            ProductId = 2,CategoryId = 2,ProductName = "Product2",Price = 10,Active = true
            }
        };
        _mockProductRepository.Setup(repo => repo.GetProducts())
            .ReturnsAsync(productList);
        
        var products = await _getProductsHandler.Handle();
        
        Assert.NotNull(products);
        Assert.NotEmpty(products);
        Assert.Equal(products.Count(), products.Count());
    }

    [Fact]
    public async Task GetProducts_ReturnsEmptyCollection()
    {
        _mockProductRepository.Setup(repo => repo.GetProducts()).ReturnsAsync((IEnumerable<Product>)null);

        await Assert.ThrowsAsync<KeyNotFoundException>(()=> _getProductsHandler.Handle());
    }
}