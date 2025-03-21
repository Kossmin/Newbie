﻿using MassTransit;
using MessagingAPI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductService.Consumers;
using ProductService.Handler;
using ProductService.IProductRepositories;
using ProductService.Models;

var builder = new HostBuilder()

    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    })
    .ConfigureServices((hostContext, services) =>
    {
        services.AddDbContext<ProductContext>();

        services.AddScoped<IProductRepository, ProductRepository>();

        // Register Handler
        services.AddScoped<GetProductsHandler>();
        services.AddScoped<GetProductByIdHandler>();
        services.AddScoped<CreateProductHandler>();
        services.AddScoped<UpdateProductHandler>();
        services.AddScoped<DeleteProductHandler>();

        services.AddMassTransit(x =>
        {
            x.AddConsumer<GetProductsRequestConsumer>()
                .Endpoint(e => e.Name = "get-products");
            x.AddConsumer<GetProductByIdRequestConsumer>();
            x.AddConsumer<UpdateProductRequestConsumer>();
            x.AddConsumer<CreateProductRequestConsumer>();
            x.AddConsumer<DeleteProductRequestConsumer>();

            x.AddRequestClient<GetProductRequest>(new Uri("exchange:get-products"));

            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost", "/", h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                cfg.ConfigureEndpoints(context);
            });

        });
    });

await builder.RunConsoleAsync();