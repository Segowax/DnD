using Microsoft.EntityFrameworkCore;

namespace Database
{
    public interface IDbContextFactory
    {
        DbContext CreateContext(string version);
    }
}
