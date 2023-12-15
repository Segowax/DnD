using DnD.Application.Contracts.Persistence;
using DnD.Application.Contracts.Persistence.Common;
using DnD.Persistence.DatabaseContext;
using DnD.Persistence.Repositories;
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
            services.AddScoped<IAbilityScoresRepository, AbilityScoresRepository>();
            services.AddScoped<ICharacterRepository, CharacterRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IDescriptionRepository, DescriptionRepository>();
            services.AddScoped<IEquipmentRepository, EquipmentRepository>();
            services.AddScoped<IRaceRepository, RaceRepository>();

            return services;
        }
    }
}
