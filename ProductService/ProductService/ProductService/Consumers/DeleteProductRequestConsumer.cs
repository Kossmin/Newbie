using MassTransit;
using MessagingAPI;
using ProductService.Handler;

namespace ProductService.Consumers;

public class DeleteProductRequestConsumer(DeleteProductHandler deleteProductHandler):IConsumer<DeleteProductRequest>
{
    public async Task Consume(ConsumeContext<DeleteProductRequest> context)
    {
        var deleteProduct = deleteProductHandler.DeleteProductAsync(context.Message);
        Console.WriteLine("Deleted product");
    }
}