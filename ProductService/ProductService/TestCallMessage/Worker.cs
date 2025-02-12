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
                // await bus.Publish(new GetProductByIdRequest()
                // {
                //     ProductId = 8
                // }, stoppingToken);
                
                // await bus.Publish(new GetProductRequest(), stoppingToken);
                
                await bus.Publish(new CreateProductRequest()
                {
                    CategoryId = 3,
                    Active = true,
                    UnitsInStock = 10,
                    ProductName = "Test",
                    Description = "Test",
                    ShortDesc = "Test",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Price = 10,
                    ThumbnailImageUrl = "https://cdn2.cellphones.com.vn/insecure/rs:fill:358:358/q:90/plain/https://cellphones.com.vn/media/catalog/product/i/p/iphone-16-pro-max.png"
                }, stoppingToken);
                
                // await bus.Publish(new UpdateProductRequest()
                // {
                //     ProductId = 1,
                //     ProductName = "Test",
                // }, stoppingToken);
                // await bus.Publish(new DeleteProductRequest()
                // {
                //     ProductId = 2,
                // }, stoppingToken);

                
                
                // await Task.Delay(1000, stoppingToken);
            // }
        }

    }
}
