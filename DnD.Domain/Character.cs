using DnD.Domain.Common;

namespace DnD.Domain
{
    public class Character : BaseEntity
    {
        public Race? Race { get; set; }
        public Class? Class { get; set; }
        public AbilityScores? AbilityScores { get; set; }
        public Description? Description { get; set; }
        public IEnumerable<Equipment>? Equipment { get; set; }
    }
}
