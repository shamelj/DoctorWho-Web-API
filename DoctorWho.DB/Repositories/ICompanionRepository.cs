using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface ICompanionRepository
    {
        void AddCompanion(Companion companion);
        void DeleteCompanion(int id);
        Task<Companion?> GetCompanionAsync(int id);
        void UpdateCompanion(Companion companion);
        Task<int> SaveChangesAsync();

    }
}