using DoctorWho.Web.Controllers;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Services;
public interface IDoctorService
{ 
    Task<List<DoctorDto>> GetAllDoctorsAsync();
    Task<DoctorDto> CreateDoctor(DoctorDto doctorDto);
    Task<bool> DoctorExists(int id);
    Task<DoctorDto> UpdateDoctorAsync(int id, DoctorDto doctorDto);
}   