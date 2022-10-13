using AutoMapper;
using DoctorWho.DB.models;
using DoctorWho.Web.Controllers;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles;

public class EpisodeProfile : Profile
{
    public EpisodeProfile()
    {
        CreateMap<EpisodeDto, Episode>();
        CreateMap<Episode, EpisodeDto>();
        CreateMap<EpisodeCreationDto, EpisodeDto>();
    }
}