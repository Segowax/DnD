using DnD.Domain.Common;

namespace DnD.Domain
{
    public class WeaponProperty : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
