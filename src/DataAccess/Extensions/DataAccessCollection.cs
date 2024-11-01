using Microsoft.Extensions.DependencyInjection;
using Products.DataAccess.Interfaces;
using Products.DataAccess.Repository;

namespace Products.DataAccess.Extensions;

public static class DataAccessCollection
{
    public static IServiceCollection AddDataAccessService(this IServiceCollection services)
    {
        services.AddScoped<ICreateProductRepository, CreateProductRepository>();
        services.AddScoped<IGetAllProductsRepository, GetAllProductsRepository>();

        return services;
    }
}
