namespace DnD.Application.Features.Equipment.Queries.GetEquipmentDetails
{
    public class GetEquipmentDetailsDto
    {
        public Guid Guid { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Weight { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
