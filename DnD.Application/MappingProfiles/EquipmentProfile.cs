using AutoMapper;
using DnD.Application.Features.Equipment.Queries.GetAllEquipments;
using DnD.Domain;

namespace DnD.Application.MappingProfiles
{
    public class EquipmentProfile : Profile
    {
        public EquipmentProfile()
        {
            CreateMap<Equipment, GetAllEquipmentsDto>().ReverseMap();
        }
    }
}
