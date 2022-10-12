using AutoMapper;
using DoctorWho.DB.models;
using DoctorWho.Web.Controllers;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles;

public class DoctorProfile : Profile
{
    public DoctorProfile()
    {
        CreateMap<Doctor, DoctorDto>();
        CreateMap<DoctorDto, Doctor>();
        CreateMap<DoctorCreationDto, DoctorDto>();
    }
}