using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.IProductRepositories;

public class ProductRepository : IProductRepository
{
    readonly ProductContext _context;

    public ProductRepository(ProductContext context)
    {
        _context = context;
    }
    
    
    public async Task<IEnumerable<Product>> GetProducts()
    {
        var products = _context.Products.ToListAsync();
        return await products;
    }
}