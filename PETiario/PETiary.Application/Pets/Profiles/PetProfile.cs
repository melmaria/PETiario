
using AutoMapper;
using PETiario.PETiary.Application.Pets.Dtos.Requests;
using PETiario.PETiary.Application.Pets.Dtos.Responses;
using PETiario.PETiary.Domain.Pets.Entities;
using PETiario.PETiary.Domain.Pets.Enumerators;

namespace PETiario.PETiary.Application.Pets.Profiles
{
    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<Pet, PetResponse>()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToString()))
                .ForMember(dest => dest.Species, opt => opt.MapFrom(src => src.Species.ToString()));

            CreateMap<PetRequest, Pet>()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom  (src => Enum.Parse<GenderEnum>(src.Gender)))
                .ForMember(dest => dest.Species, opt => opt.MapFrom(src => Enum.Parse<SpeciesEnum>(src.Species)));
        }
    }
}