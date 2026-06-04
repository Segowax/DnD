using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Database
{
    public class DbContextFactory<Ctx> : IDbContextFactory<Ctx>
        where Ctx : DbContext
    {
        private readonly IServiceProvider _serviceProvider;

        public DbContextFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Ctx GetContext()
        {
            var context = _serviceProvider.GetRequiredService<Ctx>();
            context.Database.EnsureCreated();

            return context;
        }
    }
}
