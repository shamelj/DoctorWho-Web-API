using AutoMapper;
using DoctorWho.DB.models;
using DoctorWho.Web.Controllers;

namespace DoctorWho.Web.Profiles;

public class DoctorProfile : Profile
{
    public DoctorProfile()
    {
        CreateMap<Doctor, DoctorDTO>();
        CreateMap<DoctorDTO, Doctor>();
    }
}