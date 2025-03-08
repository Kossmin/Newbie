using MassTransit;
using MessagingAPI;
using MessagingAPI.Product;
using ProductService.Handler;
using ProductService.Models;

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
            var products = await _productsHandler.Handle();

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
            await context.RespondAsync(MapResponse(products));
        }

        private GetProductResponse MapResponse(IEnumerable<Product> products)
        {
            return new GetProductResponse
            {
                Products = products.Select(p => new GetProductListItem
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName
                }).ToList(),
            };
        }
    }
}
