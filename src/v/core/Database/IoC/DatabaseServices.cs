using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Database.IoC
{
    public static class DatabaseServices
    {
        public static IServiceCollection ConfigureDatabase
            <TContext>(this IServiceCollection services)
                where TContext : DbContext
        {
            services.AddDbContext<TContext>();
            services.AddScoped<IDbContextFactory<TContext>, DbContextFactory<TContext>>();


            return services;
        }
    }
}
