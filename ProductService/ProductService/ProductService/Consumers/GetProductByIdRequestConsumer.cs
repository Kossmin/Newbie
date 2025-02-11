using MessagingAPI;
using MassTransit;
using ProductService.Handler;

namespace ProductService.Consumers;

public class GetProductByIdRequestConsumer : IConsumer<GetProductByIdRequest>
{
    private GetProductByIdHandler _getProductByIdHandler;

    public GetProductByIdRequestConsumer(GetProductByIdHandler getProductByIdHandler)
    {
        _getProductByIdHandler = getProductByIdHandler;
    }
    
    public async Task Consume(ConsumeContext<GetProductByIdRequest> context)
    {
        Console.WriteLine(await _getProductByIdHandler.GetProductByIdAsync(context.Message));
    }
}