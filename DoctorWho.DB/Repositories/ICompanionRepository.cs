using DoctorWho.DB.models;

namespace DoctorWho.Repositories
{
    public interface ICompanionRepository
    {
        Task<Companion> AddCompanionAsync(Companion companion);
        Task DeleteCompanionAsync(int id);
        Task<Companion?> GetCompanionAsync(int id);
        Task UpdateCompanionAsync(int id, Companion companion);
    }
}