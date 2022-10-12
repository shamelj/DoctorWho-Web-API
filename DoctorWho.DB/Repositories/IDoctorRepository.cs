using DoctorWho.DB.models;

namespace DoctorWho.Repositories
{
    public interface IDoctorRepository
    {
        Task<Doctor> AddDoctorAsync(Doctor doctor);
        Task DeleteDoctorAsync(int id);
        Task<Doctor?> GetDoctorAsync(int id);
        Task<List<Doctor>> GetDoctorsAsync();
        Task UpdateDoctorAsync(int id, Doctor doctor);
    }
}