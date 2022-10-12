using DoctorWho.DB.models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.DB.Repositories;

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
    public  IQueryable<Doctor> GetDoctors()
    {
        return _context.Doctors.AsQueryable();
    }
    public Doctor AddDoctorAsync(Doctor doctor)
    {
        _context.Doctors.Add(doctor);
        return doctor;
    }
    public async Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor)
    {
        var dbDoctor = await  _context.Doctors.FindAsync(id);
        if (dbDoctor != null)
        {
            dbDoctor.Name = doctor.Name;
            dbDoctor.Number = doctor.Number;
            dbDoctor.FirstEpisodeDate = doctor.FirstEpisodeDate;
            dbDoctor.LastEpisodeDate = doctor.LastEpisodeDate;
            dbDoctor.BirthDate = doctor.BirthDate;
            return dbDoctor;
        }
        return null!;
    }

    public async Task<bool> DoctorExists(int id)
    {
        return  await _context.Doctors.AnyAsync(doctor => doctor.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task DeleteDoctorAsync(int id)
    {
        var doctor = new Doctor() { Id = id };
        _context.Entry(doctor).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }

}