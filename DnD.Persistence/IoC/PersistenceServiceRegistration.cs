using DnD.Application.Contracts.Persistence.Common;
using DnD.Persistence.DatabaseContext;
using DnD.Persistence.Repositories.Common;
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

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
