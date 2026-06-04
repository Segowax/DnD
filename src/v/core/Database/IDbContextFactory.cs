using Microsoft.EntityFrameworkCore;

namespace Database
{
    public interface IDbContextFactory<Ctx>
        where Ctx : DbContext
    {
        Ctx GetContext();
    }
}
