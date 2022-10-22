using DoctorWho.DB.Repositories;

namespace DoctorWho.Web.Services;

public interface IUnitOfWork
{
    public IDoctorRepository DoctorRepository { get; }
    public IEpisodeRepository EpisodeRepository { get; }
    public IEnemyRepository EnemyRepository { get; }
    public ICompanionRepository CompanionRepository { get; }
    Task<int> SaveChangesAsync();
}