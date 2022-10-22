using DoctorWho.Web.Controllers;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Services;

public interface IEpisodeService
{
    Task<List<EpisodeDto>> GetAllEpisodesAsync();
    Task<EpisodeDto> CreateEpisode(EpisodeDto episodeDto);
    Task<bool> ExistsAsync(int episodeId);
    Task AddEnemyToEpisode(int episodeId, int enemyId);
    Task AddCompanionToEpisode(int episodeId, int companionId);
}