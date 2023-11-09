using DnD.Domain.Common;

namespace DnD.Domain
{
    public class Description : BaseEntity
    {
        public string Aligment { get; set; } = string.Empty;
        public string Background { get; set; } = string.Empty;
        public string PersonalityTraits { get; set; } = string.Empty;
        public string Ideals { get; set; } = string.Empty;
        public string Bonds { get; set; } = string.Empty;
        public string Flaws { get;set; } = string.Empty;
    }
}
