using DnD.Common.Enums;
using DnD.Domain.Common;

namespace DnD.Domain
{
    public class Equipment : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Weight { get; set; }
        public int Cost { get; set; }
        public string Damage { get; set; } = string.Empty;
        public IEnumerable<WeaponProperty> Properties { get; set; }
    }
}
