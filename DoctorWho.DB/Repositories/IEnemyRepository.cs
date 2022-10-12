using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IEnemyRepository
    {
        Task<Enemy> AddEnemyAsync(Enemy enemy);
        Task DeleteEnemyAsync(int id);
        Task<Enemy?> GetEnemyAsync(int id);
        Task UpdateEnemyAsync(int id, Enemy enemy);
    }
}