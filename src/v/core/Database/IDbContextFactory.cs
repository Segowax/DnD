using Microsoft.EntityFrameworkCore;

namespace Database
{
    public interface IDbContextFactory
    {
        DbContext GetContext(string version);
    }
}
