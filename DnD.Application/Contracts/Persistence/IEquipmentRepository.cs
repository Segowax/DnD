﻿using DnD.Application.Contracts.Persistence.Common;
using DnD.Domain;

namespace DnD.Application.Contracts.Persistence
{
    public interface IEquipmentRepository : IGenericRepository<Equipment>
    {
        Task<bool> IsEquipmentNameUnique(string name, CancellationToken cancellation = default);
    }
}

