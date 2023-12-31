﻿using DnD.Application.Contracts.Persistence;
using DnD.Domain;
using DnD.Persistence.DatabaseContext;
using DnD.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace DnD.Persistence.Repositories
{
    public class RaceRepository : GenericRepository<Race>, IRaceRepository
    {
        public RaceRepository(DndDatabaseContext context) : base(context) { }

        public async Task<bool> IsRaceNameUnique(string name, CancellationToken cancellationToken = default) =>
            !(await _context.Races.AsNoTracking().AnyAsync(x => x.Name.Equals(name), cancellationToken));
    }
}
