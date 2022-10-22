using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.DB.Repositories;

public class CompanionRepository : ICompanionRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public CompanionRepository(DoctorWhoCoreDbContext context)
    {
        _context = context;
    }
    public void AddCompanion(Companion companion)
    {
        _context.Companions.Add(companion);
    }

    public async Task<Companion?> GetCompanionAsync(int id)
    {
        return await _context.Companions.FindAsync(id);
    }

    public void UpdateCompanion(Companion companion)
    {
        _context.Entry(companion).State = EntityState.Modified;
    }
    public void DeleteCompanion(int id)
    {
        var companion = new Companion() { Id = id };
        _context.Entry(companion).State = EntityState.Deleted;
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}