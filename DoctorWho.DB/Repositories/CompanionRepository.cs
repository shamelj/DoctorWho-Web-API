using DoctorWho.DB;
using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Repositories;

public class CompanionRepository : ICompanionRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public CompanionRepository(DoctorWhoCoreDbContext context)
    {
        _context = context;
    }
    public async Task<Companion> AddCompanionAsync(Companion companion)
    {
        _context.Companions.Add(companion);
        await _context.SaveChangesAsync();
        return companion;
    }

    public async Task<Companion?> GetCompanionAsync(int id)
    {
        return await _context.Companions.FindAsync(id);
    }

    public async Task UpdateCompanionAsync(int id, Companion companion)
    {
        var dbCompanion = await _context.Companions.FindAsync(id);
        if (dbCompanion is null)
            throw new ArgumentException("Companion doesn't exist.");
        dbCompanion.Name = companion.Name;
        dbCompanion.WhoPlayed = companion.WhoPlayed;
        await _context.SaveChangesAsync();
    }
    public async Task DeleteCompanionAsync(int id)
    {
        var companion = new Companion() { Id = id };
        _context.Entry(companion).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }
}