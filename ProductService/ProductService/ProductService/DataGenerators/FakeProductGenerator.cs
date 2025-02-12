using Bogus;
using ProductService.Models;

namespace ProductService.DataGenerators;

public class FakeProductGenerator
{
    public static List<Product> GenerateProducts(int count = 10)
    {
        var faker = new Faker<Product>()
            .RuleFor(p => p.ProductId, f => f.IndexGlobal + 1)
            .RuleFor(p => p.CategoryId, f => f.Random.Int(1, 5)) // Assume 5 categories
            .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
            .RuleFor(p => p.ShortDesc, f => f.Lorem.Sentence(10))
            .RuleFor(p => p.Description, f => f.Lorem.Paragraph())
            .RuleFor(p => p.Price, f => f.Random.Decimal(10, 500))
            .RuleFor(p => p.ThumbnailImageUrl, f => f.Image.PicsumUrl())
            .RuleFor(p => p.DateCreated, f => f.Date.Past(2))
            .RuleFor(p => p.DateModified, f => f.Date.Recent(10))
            .RuleFor(p => p.Active, f => f.Random.Bool())
            .RuleFor(p => p.UnitsInStock, f => f.Random.Int(0, 100));

        return faker.Generate(count);
    }
}