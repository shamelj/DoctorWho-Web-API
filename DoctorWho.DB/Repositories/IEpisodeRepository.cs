using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IEpisodeRepository
    {
        Task<Episode> AddEnemyAsync(Episode episode);
        Task AddEnemyToEpisode(int episodeId, int enemyId);
        Task DeleteEpisodeAsync(int id);
        Task<Episode?> GetEnemyAsync(int id);
        Task UpdateEpisodeAsync(int id, Episode episode);
    }
}