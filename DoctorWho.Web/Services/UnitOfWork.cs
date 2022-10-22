using DoctorWho.DB;
using DoctorWho.DB.Repositories;

namespace DoctorWho.Web.Services;

public class UnitOfWork : IUnitOfWork
{
    private readonly DoctorWhoCoreDbContext _context;
    public IDoctorRepository DoctorRepository { get; }
    public IEpisodeRepository EpisodeRepository { get; }
    public IEnemyRepository EnemyRepository { get; }
    public ICompanionRepository CompanionRepository { get; }

    public UnitOfWork(DoctorWhoCoreDbContext context, IDoctorRepository doctorRepository, IEpisodeRepository episodeRepository, IEnemyRepository enemyRepository, ICompanionRepository companionRepository)
    {
        _context = context;
        DoctorRepository = doctorRepository;
        EpisodeRepository = episodeRepository;
        EnemyRepository = enemyRepository;
        CompanionRepository = companionRepository;
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}