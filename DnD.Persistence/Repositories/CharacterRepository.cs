using DnD.Application.Contracts.Persistence;
using DnD.Domain;
using DnD.Persistence.DatabaseContext;
using DnD.Persistence.Repositories.Common;

namespace DnD.Persistence.Repositories
{
    public class CharacterRepository : GenericRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(DndDatabaseContext context) : base(context) { }

        public async Task CreateRandomCharacter()
        {
            // ToDo
            // 1. Draw a Race
            // 2. Draw a Class
            // 3. Draw and set Ability Scores
            // 4. Create Description
            // 5. Draw Equipment
            // 6. Merge
            await Task.CompletedTask;
        }
    }
}
