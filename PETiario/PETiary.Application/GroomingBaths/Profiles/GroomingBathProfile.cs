
using AutoMapper;
using PETiario.PETiary.Application.GroomingBaths.Dtos.Requests;
using PETiario.PETiary.Application.GroomingBaths.Dtos.Responses;
using PETiario.PETiary.Domain.GroomingBaths.Entities;
using PETiario.PETiary.Domain.GroomingBaths.Enumerators;

namespace PETiario.PETiary.Application.GroomingBaths.Profiles
{
    public class GroomingBathProfile : Profile
    {
        public GroomingBathProfile()
        {
            CreateMap<GroomingBath, GroomingBathResponse>()
                .ForMember(dest => dest.Kind, opt => opt.MapFrom(src => src.Kind.ToString()));
                
            CreateMap<GroomingBathRequest, GroomingBath>()
                .ForMember(dest => dest.Kind, opt => opt.MapFrom(src => Enum.Parse<KindEnum>(src.Kind))); 
        }
    }
}