using DoctorWho.DB.models;

namespace DoctorWho.DB.Repositories
{
    public interface IDoctorRepository
    {
        Task<Doctor> AddDoctorAsync(Doctor doctor);
        Task DeleteDoctorAsync(int id);
        Task<Doctor?> GetDoctorAsync(int id);
        IQueryable<Doctor> GetDoctors();
        Task UpdateDoctorAsync(int id, Doctor doctor);
    }
}