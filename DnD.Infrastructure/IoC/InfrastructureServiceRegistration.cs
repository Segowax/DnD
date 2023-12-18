using DnD.Application.Contracts.Logging;
using DnD.Infrastructure.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DnD.Infrastructure.IoC
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            return services;
        }
    }
}
