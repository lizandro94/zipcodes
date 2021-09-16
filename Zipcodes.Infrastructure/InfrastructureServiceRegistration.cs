using Microsoft.Extensions.DependencyInjection;
using Zipcodes.Application.Contracts;
using Zipcodes.Infrastructure.HtmlPack;

namespace Zipcodes.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IHtmlPackService, HtmlPackService>();

            return services;
        }
    }
}
