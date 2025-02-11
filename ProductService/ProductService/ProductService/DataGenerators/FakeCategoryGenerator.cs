using Bogus;
using ProductService.Models;

namespace ProductService.DataGenerators;

public class FakeCategoryGenerator
{
    public static List<Category> GenerateCategories(int count = 5)
    {
        var faker = new Faker<Category>()
            .RuleFor(c => c.Id, f => f.IndexGlobal + 1)
            .RuleFor(c => c.CatName, f => f.Commerce.Categories(1)[0]) // Random category name
            .RuleFor(c => c.Description, f => f.Lorem.Sentence(10));

        return faker.Generate(count);
    }
}