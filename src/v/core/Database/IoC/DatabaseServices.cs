using Database.v5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
                    services.AddScoped<IDbContextFactory<V5Ctx>, DbContextFactory<V5Ctx>>();
                    break;
                default:
                    throw new NotImplementedException($"No database configuration implemented for DnD version {dndVersion}");
            }

            return services;
        }
    }
}
