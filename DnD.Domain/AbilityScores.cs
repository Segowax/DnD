using DnD.Domain.Common;

namespace DnD.Domain
{
    public class AbilityScores : BaseEntity
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get;set; }
        public int Wisdom { get;set; }
        public int Charisma { get; set; }
    }
}
