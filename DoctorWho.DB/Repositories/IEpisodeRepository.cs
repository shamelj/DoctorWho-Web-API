using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IEpisodeRepository
    {
        Task<Episode?> GetEpisodeAsync(int id);
        Task<Episode> AddEpisodeAsync(Episode episode);
        Task AddEnemyToEpisode(int episodeId, int enemyId);
        void DeleteEpisode(int id);
        Task UpdateEpisodeAsync(int id, Episode episode);
        IQueryable<Episode> GetAllEpisodes();
        Task SaveChangesAsync();
    }
}