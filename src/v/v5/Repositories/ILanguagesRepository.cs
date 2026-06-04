using Database.BaseRepository;
using Database.v5;
using Domain;

namespace v5.Repositories
{
    public interface ILanguagesRepository
        : IBaseRepository<V5Ctx, Languages>
    { }
}
