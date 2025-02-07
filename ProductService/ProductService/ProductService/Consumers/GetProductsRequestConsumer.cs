using MassTransit;
using MessagingAPI;

namespace ProductService.Consumers
{
    public class GetProductsRequestConsumer : IConsumer<GetProductRequest>
    {
        public Task Consume(ConsumeContext<GetProductRequest> context)
        {
            Console.Write("Debugger");
            return Task.CompletedTask;
        }
    }
}
