using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.DB.Repositories;

public class EnemyRepository : IEnemyRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public EnemyRepository(DoctorWhoCoreDbContext context)
    {
        _context = context;
    }

    public async Task<Enemy?> GetEnemyAsync(int id)
    {
        return await _context.Enemys.FindAsync(id);
    }
    public void AddEnemy(Enemy enemy)
    {
        _context.Enemys.Add(enemy);
    }
    public void UpdateEnemy(Enemy enemy)
    {
        _context.Entry(enemy).State = EntityState.Modified;
    }
    public void DeleteEnemy(int id)
    {
        var enemy = new Enemy() { Id = id };
        _context.Entry(enemy).State = EntityState.Deleted;
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task<bool> Exists(int enemyId)
    {
     return await _context.Enemys.AnyAsync(enemy => enemy.Id == enemyId);
    }
}