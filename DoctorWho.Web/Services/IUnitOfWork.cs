using DoctorWho.DB;
using DoctorWho.DB.Repositories;

namespace DoctorWho.Web.Services;

public interface IUnitOfWork
{
    public IDoctorRepository DoctorRepository { get; }
    public IEpisodeRepository EpisodeRepository { get; }
    Task<int> SaveChangesAsync();
}

class UnitOfWork : IUnitOfWork
{
    private readonly DoctorWhoCoreDbContext _context;
    public IDoctorRepository DoctorRepository { get; }
    public IEpisodeRepository EpisodeRepository { get; }
    public UnitOfWork(DoctorWhoCoreDbContext context, IDoctorRepository doctorRepository, IEpisodeRepository episodeRepository)
    {
        _context = context;
        DoctorRepository = doctorRepository;
        EpisodeRepository = episodeRepository;
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}