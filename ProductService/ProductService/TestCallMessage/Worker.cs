using MassTransit;
using MessagingAPI;
using Microsoft.Extensions.Hosting;

namespace TestCallMessage
{
    internal class Worker(IBus bus) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // while (!stoppingToken.IsCancellationRequested) 
            // {
                await bus.Publish(new GetProductByIdRequest()
                {
                    ProductId = 8
                }, stoppingToken);
                
                await bus.Publish(new GetProductRequest(), stoppingToken);
                
                // await Task.Delay(1000, stoppingToken);
            // }
        }

    }
}
