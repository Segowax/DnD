using AutoMapper;
using DnD.Application.Features.Equipment.Commands.CreateEquipment;
using DnD.Application.Features.Equipment.Commands.DeleteEquipment;
using DnD.Application.Features.Equipment.Commands.UpdateEquipment;
using DnD.Application.Features.Equipment.Queries.GetAllEquipments;
using DnD.Application.Features.Equipment.Queries.GetEquipmentDetails;
using DnD.Domain;

namespace DnD.Application.MappingProfiles
{
    public class EquipmentProfile : Profile
    {
        public EquipmentProfile()
        {
            CreateMap<GetAllEquipmentsDto, Equipment>();
            CreateMap<GetEquipmentDetailsDto, Equipment>();
            CreateMap<Equipment, UpdateEquipmentCommand>();
            CreateMap<Equipment, CreateEquipmentCommand>();
            CreateMap<Equipment, DeleteEquipmentCommand>();
        }
    }
}
