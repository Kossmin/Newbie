﻿using MassTransit;
using MessagingAPI;
using ProductService.Handler;

namespace ProductService.Consumers
{
    public class GetProductsRequestConsumer : IConsumer<GetProductRequest>
    {
        private GetProductsHandler _productsHandler;

        public GetProductsRequestConsumer(GetProductsHandler productsHandler)
        {
            _productsHandler = productsHandler;
        }
        public async Task Consume(ConsumeContext<GetProductRequest> context)
        {
            var getHandle = await _productsHandler.Handle();

            foreach (var product in getHandle)
            {
                Console.WriteLine(product.ProductName);
            }
            // return Task.CompletedTask;
        }
    }
}
