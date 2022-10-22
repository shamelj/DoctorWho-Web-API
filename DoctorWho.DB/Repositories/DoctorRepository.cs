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
    public  Task<List<Doctor>> GetDoctorsAsync()
    {
        return _context.Doctors.ToListAsync();
    }
    public void AddDoctor(Doctor doctor)
    {
        _context.Doctors.Add(doctor);
    }
    public void UpdateDoctor(Doctor doctor)
    {
        _context.Entry(doctor).State = EntityState.Modified;
    }

    public async Task<bool> DoctorExists(int id)
    {
        return  await _context.Doctors.AnyAsync(doctor => doctor.Id == id);
    }

    public void DeleteDoctor(int id)
    {
        var doctor = new Doctor() { Id = id };
        _context.Entry(doctor).State = EntityState.Deleted;
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}