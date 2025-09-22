
using AutoMapper;
using PETiario.PETiary.Application.Walks.Dtos.Requests;
using PETiario.PETiary.Application.Walks.Dtos.Responses;
using PETiario.PETiary.Domain.Walks.Entities;

namespace PETiario.PETiary.Application.Walks.Profiles
{
    public class WalkProfile : Profile
    {
        public WalkProfile()
        {
            CreateMap<Walk, WalkResponse>();
            CreateMap<WalkRequest, Walk>();
        }
    }
}