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

    public async Task<Episode?> GetEnemyAsync(int id)
    {
        return await _context.Episodes.FindAsync(id);
    }
    public async Task<Episode> AddEnemyAsync(Episode episode)
    {
        _context.Episodes.Add(episode);
        await _context.SaveChangesAsync();
        return episode;
    }
    public async Task UpdateEpisodeAsync(int id, Episode episode)
    {
        var dbEpisode = await _context.Episodes.FindAsync(id);
        if (dbEpisode is null)
            throw new ArgumentException("Episode doesn't exist.");
        dbEpisode.Title = episode.Title;
        dbEpisode.Notes = episode.Notes;
        dbEpisode.AuthorId = episode.AuthorId;
        dbEpisode.DoctorId = dbEpisode.DoctorId;
        dbEpisode.EpisodeDate = episode.EpisodeDate;
        dbEpisode.EpisodeNumber = episode.EpisodeNumber;
        dbEpisode.Type = episode.Type;
        dbEpisode.SeriesNumber = episode.SeriesNumber;
        await _context.SaveChangesAsync();
    }
    public async Task DeleteEpisodeAsync(int id)
    {
        var episode = new Episode() { Id = id };
        _context.Entry(episode).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }

    public async Task AddEnemyToEpisode(int episodeId, int enemyId)
    {
        var episode = await _context.Episodes.FindAsync(episodeId);
        if (episode is null)
            return;
        var enemy = await _context.Enemys.FindAsync(enemyId);
        if (enemy is null)
            return;
        _context.EpisodeEnemys.Add(new EpisodeEnemy() { EnemyId = enemyId, EpisodeId = episodeId });
        await _context.SaveChangesAsync();
    }
}