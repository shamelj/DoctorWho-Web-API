using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IEnemyRepository
    {
        void AddEnemy(Enemy enemy);
        void DeleteEnemy(int id);
        Task<Enemy?> GetEnemyAsync(int id);
        void UpdateEnemy(Enemy enemy);
        Task<int> SaveChangesAsync();

        Task<bool> Exists(int enemyId);
    }
}