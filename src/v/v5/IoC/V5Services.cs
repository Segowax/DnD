using Database.IoC;
using Microsoft.Extensions.DependencyInjection;
using static Common.Constants;

namespace v5.IoC
{
    public static class V5Services
    {
        public static IServiceCollection ConfigureV5(this IServiceCollection services)
        {
            services.ConfigureDatabase(DnDVersion.V5);

            return services;
        }
    }
}
