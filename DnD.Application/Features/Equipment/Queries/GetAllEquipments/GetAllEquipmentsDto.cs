namespace DnD.Application.Features.Equipment.Queries.GetAllEquipments
{
    public class GetAllEquipmentsDto
    {
        public Guid Guid { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Weight { get; set; }
    }
}
