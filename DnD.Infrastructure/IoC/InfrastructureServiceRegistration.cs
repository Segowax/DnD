using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DnD.Infrastructure.IoC
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            return services;
        }
    }
}
