
using AutoMapper;
using PETiario.PETiary.Application.Appointements.Dtos.Requests;
using PETiario.PETiary.Application.Appointements.Dtos.Responses;
using PETiario.PETiary.Domain.Appointments.Entities;

namespace PETiario.PETiary.Application.Appointements.Profiles
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<Appointment, AppointmentsResponse>();
            CreateMap<AppointmentsRequest, Appointment>();
        }
        
    }
}