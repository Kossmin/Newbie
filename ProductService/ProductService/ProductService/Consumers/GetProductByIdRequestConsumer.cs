using MessagingAPI;
using MassTransit;
using ProductService.Handler;

namespace ProductService.Consumers;

public class GetProductByIdRequestConsumer : IConsumer<GetProductByIdRequest>
{
    private GetProductByIdHandler _getProductByIdHandler;

    public GetProductByIdRequestConsumer()
    {
        _getProductByIdHandler = new GetProductByIdHandler();
    }
    
    public async Task Consume(ConsumeContext<GetProductByIdRequest> context)
    {
        Console.WriteLine(await _getProductByIdHandler.GetProductByIdAsync(context.Message));
    }
}