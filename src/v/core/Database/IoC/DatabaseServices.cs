using Database.v5;
using Microsoft.Extensions.DependencyInjection;
using static Common.Constants;

namespace Database.IoC
{
    public static class DatabaseServices
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services, string dndVersion)
        {
            switch (dndVersion)
            {
                case DnDVersion.V5:
                    services.AddDbContext<V5Ctx>();
                    break;
                default:
                    throw new NotImplementedException($"No database configuration implemented for DnD version {dndVersion}");
            }

            services.AddScoped<IDbContextFactory, DbContextFactory>();

            return services;
        }
    }
}
