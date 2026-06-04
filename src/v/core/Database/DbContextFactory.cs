using Database.v5;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using static Common.Constants;

namespace Database
{
    public class DbContextFactory : IDbContextFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DbContextFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public DbContext GetContext(string version)
        {
            var context = version switch
            {
                DnDVersion.V5 => _serviceProvider.GetRequiredService<V5Ctx>(),
                _ => throw new ArgumentException($"Unsupported DnD version: {version}"),

            };
            context.Database.EnsureCreated();

            return context;
        }
    }
}
