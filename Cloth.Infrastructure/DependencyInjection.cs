﻿namespace Cloth.Infrastructure.Extensions;

using Cloth.Application;
using Cloth.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        if (configuration == null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }
        services.AddScoped<IClothRepository, ClothRepository>();
        services.AddScoped<IClothService, ClothService>();
        services.AddHttpClient<ReadJsonFromUrlClient>();
        services.AddScoped<IReadJsonFromUrlClient, ReadJsonFromUrlClient>();

        return services;
    }
}
