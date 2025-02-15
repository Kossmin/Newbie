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

    public async Task<Product> GetProductById(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return null;
        }
        return product;
    }

    public async Task<Product> CreateProduct(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }
    
    public async Task<bool> CategoryExists(int categoryId)
    {
        return await _context.Categories.AnyAsync(c => c.Id == categoryId);
    }

    public async Task<Product> UpdateProduct(Product product)
    {
        var existProduct = await _context.Products.FindAsync(product.ProductId);

        if (existProduct == null)
        {
            return null;
        }
        
        existProduct.ProductName = product.ProductName ?? existProduct.ProductName;
        existProduct.CategoryId = product.CategoryId ?? existProduct.CategoryId;
        existProduct.ShortDesc = product.ShortDesc ?? existProduct.ShortDesc;
        existProduct.Description = product.Description ?? existProduct.Description;
        existProduct.Price = product.Price != 0  ? product.Price : existProduct.Price;
        existProduct.ThumbnailImageUrl = product.ThumbnailImageUrl ?? existProduct.ThumbnailImageUrl;
        existProduct.DateModified = DateTime.UtcNow;
        existProduct.Active = product.Active;
        existProduct.UnitsInStock = product.UnitsInStock ?? existProduct.UnitsInStock;
        
        await _context.SaveChangesAsync();
        
        return existProduct; 
    }

    public async Task<Product> DeleteProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        
        if (product == null)
        {
            return null;
        }
        
        _context.Products.Remove(product);
        
        await _context.SaveChangesAsync();
        
        return product;
    }
}