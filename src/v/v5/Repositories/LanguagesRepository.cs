using Database;
using Database.BaseRepository;
using Database.v5;
using Domain;

namespace v5.Repositories
{
    public sealed class LanguagesRepository
        : BaseRepository<V5Ctx, Languages>, ILanguagesRepository
    {
        public LanguagesRepository(IDbContextFactory<V5Ctx> dbContextFactory)
            : base(dbContextFactory) { }
    }
}
