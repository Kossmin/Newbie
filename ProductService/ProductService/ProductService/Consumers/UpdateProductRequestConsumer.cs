using MassTransit;
using MessagingAPI;
using ProductService.Handler;
using ProductService.Models;

namespace ProductService.Consumers;

public class UpdateProductRequestConsumer(UpdateProductHandler updateProductHandler): IConsumer<UpdateProductRequest>
{
    public async Task Consume(ConsumeContext<UpdateProductRequest> context)
    {
        var updateRequest = updateProductHandler.UpdateProductAsync(context.Message);

        Console.WriteLine(updateRequest);
    }
}