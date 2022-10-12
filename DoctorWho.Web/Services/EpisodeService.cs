using AutoMapper;
using DoctorWho.DB.Repositories;
using DoctorWho.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Web.Services;

class EpisodeService : IEpisodeService
{
    private readonly IEpisodeRepository _episodeRepository;
    private readonly IMapper _mapper;
    
    public EpisodeService(IEpisodeRepository episodeRepository, IMapper mapper)
    {
        _episodeRepository = episodeRepository;
        _mapper = mapper;
    }

    public async Task<List<EpisodeDto>> GetAllEpisodesAsync()
    {
        return await _episodeRepository.GetAllEpisodes()
            .Select(episodeEntity => _mapper.Map<EpisodeDto>(episodeEntity))
            .ToListAsync();
    }
}