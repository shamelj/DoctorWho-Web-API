using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.DB.Repositories;

public class EpisodeRepository : IEpisodeRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public EpisodeRepository(DoctorWhoCoreDbContext context)
    {
        _context = context;
    }

    public async Task<Episode?> GetEpisodeAsync(int id)
    {
        return await _context.Episodes.FindAsync(id);
    }
    public void AddEpisode(Episode episode)
    {
        _context.Episodes.Add(episode);
    }

    public void UpdateEpisode(Episode episode)
    {
        _context.Entry(episode).State = EntityState.Modified;

    }

    public async Task<IEnumerable<Episode>> GetAllEpisodes()
    {
        return await _context.Episodes.ToListAsync();
    }
    public void DeleteEpisode(int id)
    {
        var episode = new Episode() { Id = id };
        _context.Entry(episode).State = EntityState.Deleted;
    }

    public void AddEnemyToEpisode(int episodeId, int enemyId)
    {
        _context.EpisodeEnemys.Add(new EpisodeEnemy() { EnemyId = enemyId, EpisodeId = episodeId });
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}