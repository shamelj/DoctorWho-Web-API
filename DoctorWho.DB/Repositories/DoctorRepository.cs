using DoctorWho.DB;
using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Repositories;

public class DoctorRepository : IDoctorRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public DoctorRepository(DoctorWhoCoreDbContext context)
    {
        _context = context;
    }

    public async Task<Doctor?> GetDoctorAsync(int id)
    {
        return await _context.Doctors.FindAsync(id);
    }
    public async Task<List<Doctor>> GetDoctorsAsync()
    {
        return await _context.Doctors.ToListAsync();
    }
    public async Task<Doctor> AddDoctorAsync(Doctor doctor)
    {
        _context.Doctors.Add(doctor);
        await _context.SaveChangesAsync();
        return doctor;
    }
    public async Task UpdateDoctorAsync(int id, Doctor doctor)
    {
        var dbDoctor = await _context.Doctors.FindAsync(id);
        if (dbDoctor is null)
            throw new ArgumentException("Doctor doesn't exist.");
        dbDoctor.Name = doctor.Name;
        dbDoctor.Number = doctor.Number;
        dbDoctor.FirstEpisodeDate = doctor.FirstEpisodeDate;
        dbDoctor.LastEpisodeDate = doctor.LastEpisodeDate;
        dbDoctor.BirthDate = doctor.BirthDate;
        await _context.SaveChangesAsync();
    }
    public async Task DeleteDoctorAsync(int id)
    {
        var doctor = new Doctor() { Id = id };
        _context.Entry(doctor).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }

}