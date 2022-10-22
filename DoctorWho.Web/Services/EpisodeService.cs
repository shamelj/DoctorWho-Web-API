using AutoMapper;
using DoctorWho.DB.models;
using DoctorWho.DB.Repositories;
using DoctorWho.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Web.Services;

public class EpisodeService : IEpisodeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public EpisodeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<EpisodeDto>> GetAllEpisodesAsync()
    {
        return (await _unitOfWork.EpisodeRepository.GetAllEpisodes())
            .Select(episodeEntity => _mapper.Map<EpisodeDto>(episodeEntity))
            .ToList();
    }

    public async Task<EpisodeDto> CreateEpisode(EpisodeDto episodeDto)
    {
        _unitOfWork.EpisodeRepository.AddEpisode(_mapper.Map<Episode>(episodeDto));
        await _unitOfWork.SaveChangesAsync();
        var createdEpisode = _unitOfWork.EpisodeRepository.GetEpisodeAsync(episodeDto.Id);
        return _mapper.Map<EpisodeDto>(createdEpisode);
    }

    public async Task<bool> ExistsAsync(int episodeId)
    {
        return await _unitOfWork.EpisodeRepository.ExistsAsync(episodeId);
    }

    public async Task AddEnemyToEpisode(int episodeId, int enemyId)
    {
        _unitOfWork.EpisodeRepository.AddEnemyToEpisode(episodeId,enemyId);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task AddCompanionToEpisode(int episodeId, int companionId)
    {
        _unitOfWork.EpisodeRepository.AddCompanionToEpisode(episodeId, companionId);
        await _unitOfWork.SaveChangesAsync();
    }
}