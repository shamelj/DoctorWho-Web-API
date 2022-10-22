using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IDoctorRepository
    {
        void AddDoctor(Doctor doctor);
        void DeleteDoctor(int id);
        Task<Doctor?> GetDoctorAsync(int id);
        Task<List<Doctor>> GetDoctorsAsync();
        void UpdateDoctor(Doctor doctor);
        Task<bool> DoctorExists(int id);
        Task<int> SaveChangesAsync();
    }
}