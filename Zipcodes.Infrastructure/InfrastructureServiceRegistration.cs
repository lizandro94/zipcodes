using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Zipcodes.Application.Contracts;
using Zipcodes.Infrastructure.HtmlPack;

namespace Zipcodes.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IPostalRecordRepository, HtmlPackService>();

            return services;
        }
    }
}
