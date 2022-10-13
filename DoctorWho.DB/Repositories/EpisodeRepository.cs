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
    public async Task<Episode> AddEpisodeAsync(Episode episode)
    {
        await _context.Episodes.AddAsync(episode);
        return episode;
    }

    public void DeleteEpisode(int id)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateEpisodeAsync(int id, Episode episode)
    {
        var dbEpisode = await _context.Episodes.FindAsync(id);
        if (dbEpisode != null)
        {
            dbEpisode.Title = episode.Title;
            dbEpisode.Notes = episode.Notes;
            dbEpisode.AuthorId = episode.AuthorId;
            dbEpisode.DoctorId = dbEpisode.DoctorId;
            dbEpisode.EpisodeDate = episode.EpisodeDate;
            dbEpisode.EpisodeNumber = episode.EpisodeNumber;
            dbEpisode.Type = episode.Type;
            dbEpisode.SeriesNumber = episode.SeriesNumber;
        }
    }

    public IQueryable<Episode> GetAllEpisodes()
    {
        return _context.Episodes.AsQueryable();
    }
    public async Task DeleteEpisodeAsync(int id)
    {
        var episode = new Episode() { Id = id };
        _context.Entry(episode).State = EntityState.Deleted;
    }

    public async Task AddEnemyToEpisode(int episodeId, int enemyId)
    {
        await _context.EpisodeEnemys.AddAsync(new EpisodeEnemy() { EnemyId = enemyId, EpisodeId = episodeId });
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}