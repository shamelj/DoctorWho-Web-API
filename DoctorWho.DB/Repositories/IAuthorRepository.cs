using DoctorWho.DB.models;

namespace DoctorWho.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> AddAuthor(Author author);
        Task DeleteAuthorAsync(int id);
        Task<Author?> GetAuthorAsync(int id);
        Task UpdateAuthorAsync(int id, Author author);
    }
}