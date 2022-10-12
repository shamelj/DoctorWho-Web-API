using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IDoctorRepository
    {
        Doctor AddDoctorAsync(Doctor doctor);
        void DeleteDoctorAsync(int id);
        Task<Doctor?> GetDoctorAsync(int id);
        IQueryable<Doctor> GetDoctors();
        Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor);
        Task<bool> DoctorExists(int id);
        Task SaveChangesAsync();
    }
}