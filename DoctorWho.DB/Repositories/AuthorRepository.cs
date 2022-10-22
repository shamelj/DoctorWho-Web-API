using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.DB.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public AuthorRepository(DoctorWhoCoreDbContext context)
    {
        _context = context;
    }

    public void AddAuthor(Author author)
    {
        _context.Authors.Add(author);
    }

    public async Task<Author?> GetAuthorAsync(int id)
    {
        return await _context.Authors.FindAsync(id);
    }

    public void UpdateAuthor(Author author)
    {
        _context.Entry(author).State = EntityState.Modified;
    }

    public void DeleteAuthor(int id)
    {
        var author = new Author() { Id = id };
        _context.Entry(author).State = EntityState.Deleted;
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}