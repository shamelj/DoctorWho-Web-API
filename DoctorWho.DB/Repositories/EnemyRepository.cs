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
    public async Task<Enemy> AddEnemyAsync(Enemy enemy)
    {
        _context.Enemys.Add(enemy);
        await _context.SaveChangesAsync();
        return enemy;
    }
    public async Task UpdateEnemyAsync(int id, Enemy enemy)
    {
        var dbEnemy = await _context.Enemys.FindAsync(id);
        if (dbEnemy is null)
            throw new ArgumentException("Enemy doesn't exist.");
        dbEnemy.Name = enemy.Name;
        dbEnemy.Description = enemy.Description;
        await _context.SaveChangesAsync();
    }
    public async Task DeleteEnemyAsync(int id)
    {
        var enemy = new Enemy() { Id = id };
        _context.Entry(enemy).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }
}