using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
            return services;
        }
    }
}
