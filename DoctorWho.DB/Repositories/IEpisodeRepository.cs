using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IEpisodeRepository
    {
        Task<Episode?> GetEpisodeAsync(int id);
        void AddEpisode(Episode episode);
        void AddEnemyToEpisode(int episodeId, int enemyId);
        void DeleteEpisode(int id);
        void UpdateEpisode(Episode episode);
        Task<IEnumerable<Episode>> GetAllEpisodes();
        Task<int> SaveChangesAsync();
    }
}