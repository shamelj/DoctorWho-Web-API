using DoctorWho.DB;
using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public AuthorRepository(DoctorWhoCoreDbContext context)
    {
        _context = context;
    }

    public async Task<Author> AddAuthor(Author author)
    {
        _context.Authors.Add(author);
        await _context.SaveChangesAsync();
        return author;
    }

    public async Task<Author?> GetAuthorAsync(int id)
    {
        return await _context.Authors.FindAsync(id);
    }

    public async Task UpdateAuthorAsync(int id, Author author)
    {
        var dbAuthor = await _context.Authors.FindAsync(id);
        if (dbAuthor is null)
            throw new ArgumentException("Author doesn't exist.");
        dbAuthor.Name = author.Name;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAuthorAsync(int id)
    {
        var author = new Author() { Id = id };
        _context.Entry(author).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }
}