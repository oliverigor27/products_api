using Products.Application.Extensions;
using Products.DataAccess.Extensions;

namespace Products.Api.Extensions;

public static class ApiCollection
{
    public static WebApplicationBuilder AddApibuilder(this WebApplicationBuilder builder)
    {
        builder.Services.AddServiceCollection();
        builder.Services.AddDataAccessService();

        return builder;
    }
}
