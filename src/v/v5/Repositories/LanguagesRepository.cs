using Database;
using Database.BaseRepository;
using Domain;
using static Common.Constants;

namespace v5.Repositories
{
    public sealed class LanguagesRepository : BaseRepository<Languages>, ILanguagesRepository
    {
        public LanguagesRepository(IDbContextFactory dbContextFactory)
            : base(dbContextFactory, DnDVersion.V5) { }
    }
}
