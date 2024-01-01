using AutoMapper;
using DnD.Application.Features.Race.Commands.CreateRace;
using DnD.Application.Features.Race.Commands.DeleteRace;
using DnD.Application.Features.Race.Commands.UpdateRace;
using DnD.Application.Features.Race.Queries.GetAllRaces;
using DnD.Application.Features.Race.Queries.GetRaceDetails;
using DnD.Domain;

namespace DnD.Application.MappingProfiles
{
    public class RaceProfile : Profile
    {
        public RaceProfile()
        {
            CreateMap<Race, GetAllRacesDto>();
            CreateMap<Race, GetRaceDetailsDto>();
            CreateMap<CreateRaceCommand, Race>();
            CreateMap<UpdateRaceCommand, Race>();
            CreateMap<DeleteRaceCommand, Race>();
        }
    }
}