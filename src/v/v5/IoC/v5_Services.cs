using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using v5.Data;

namespace v5.IoC
{
    public static class v5_Services
    {
        public static IServiceCollection AddServicesForV5(this IServiceCollection services)
        {
            services.AddDbContext<DnDContext>
                (options => options.UseSqlite("Data Source=database.db"));

            using(var context = new DnDContext())
            {
                context.Database.EnsureCreated();
            }

            return services;
        }
    }
}
