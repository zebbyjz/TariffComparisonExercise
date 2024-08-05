using Microsoft.Extensions.DependencyInjection;
using TariffCalculator.Application.Interfaces.ExternalServices;
using TariffCalculator.Domain.DomainServices;
using TariffCalculator.Domain.Interfaces.DomainServices;

namespace TariffCalculator.Application
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension method for injecting dependencies relevant to application layer.
        /// <br></br>
        /// To be called from Entry point of WebAPI.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplication (this IServiceCollection services)
        {
            services.AddTransient<IProductComparisonService, ProductComparisonService>();
            return services;
        }
    }
}
