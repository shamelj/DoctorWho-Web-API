using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IAuthorRepository
    {
        void AddAuthor(Author author);
        void DeleteAuthor(int id);
        Task<Author?> GetAuthorAsync(int id);
        void UpdateAuthor(Author author);
        Task<int> SaveChangesAsync();

    }
}