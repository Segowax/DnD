using DnD.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DnD.Persistence.IoC
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<DndDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DnDDatabaseConnectionString"));
            });

            return services;
        }
    }
}
