namespace DnD.Application.Features.Race.Queries.GetAllRaces
{
    public class GetRaceDetailsDto
    {
        public Guid Guid { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
