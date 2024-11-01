using Microsoft.Extensions.DependencyInjection;
using Products.Application.Services;

namespace Products.Application.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddServiceCollection(this IServiceCollection services)
    {
        return services.AddScoped<CreateProductService>();
    }
}
