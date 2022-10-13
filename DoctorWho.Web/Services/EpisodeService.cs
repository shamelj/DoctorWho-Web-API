using AutoMapper;
using DoctorWho.DB.models;
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

    public async Task<EpisodeDto> CreateEpisode(EpisodeDto episodeDto)
    {
        var episodeEntity = await _episodeRepository.AddEpisodeAsync(_mapper.Map<Episode>(episodeDto));
        await _episodeRepository.SaveChangesAsync();
        return _mapper.Map<EpisodeDto>(episodeEntity);
    }
}