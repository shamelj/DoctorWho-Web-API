namespace DoctorWho.Web.Services;

public interface IEnemyService
{
    Task<bool> EnemyExists(int enemyId);
}