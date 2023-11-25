using AutoMapper;
using DnD.Application.Features.Race.Queries.GetAllRaces;
using DnD.Application.Features.Race.Queries.GetRaceDetails;
using DnD.Domain;

namespace DnD.Application.MappingProfiles
{
    public class RaceProfile : Profile
    {
        public RaceProfile()
        {
            CreateMap<GetAllRacesDto, Race>();
            CreateMap<GetRaceDetailsDto, Race>();
        }
    }
}