
using AutoMapper;
using PETiario.PETiary.Application.Vaccinations.Dtos.Requests;
using PETiario.PETiary.Application.Vaccinations.Dtos.Responses;
using PETiario.PETiary.Domain.Vaccinations.Entities;

namespace PETiario.PETiary.Application.Vaccinations.Profiles
{
    public class VaccinationProfile : Profile
    {
        public VaccinationProfile()
        {
            CreateMap<Vaccination, VaccinationResponse>();
            CreateMap<VaccionationRequest, Vaccination>();
        }
        
    }
}