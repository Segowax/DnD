using Database.IoC;
using Database.v5;
using Microsoft.Extensions.DependencyInjection;
using v5.Repositories;

namespace v5.IoC
{
    public static class V5Services
    {
        public static IServiceCollection ConfigureV5(this IServiceCollection services)
        {
            services.ConfigureDatabase<V5Ctx>();
            services.AddScoped<ILanguagesRepository, LanguagesRepository>();

            return services;
        }
    }
}
