using MassTransit;
using MessagingAPI;
using ProductService.Handler;
using ProductService.Models;

namespace ProductService.Consumers;

public class CreateProductRequestConsumer(CreateProductHandler createProductHandler) : IConsumer<CreateProductRequest>
{
    public async Task Consume(ConsumeContext<CreateProductRequest> context)
    {
        var createProduct = await createProductHandler.CreateProductAsync(context.Message);
        
        Console.WriteLine(createProduct);
    }
}
