using Microsoft.Extensions.DependencyInjection;

namespace TariffCalculator.Infrastructure
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension method for injecting dependencies relevant to Infrastructure layer like external services and Database access.
        /// <br></br>
        /// To be called from Entry point of WebAPI.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure (this IServiceCollection services)
        {
            return services;
        }
    }
}
