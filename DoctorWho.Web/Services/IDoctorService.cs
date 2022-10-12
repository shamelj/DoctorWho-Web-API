using DoctorWho.Web.Controllers;

namespace DoctorWho.Web.Services;
public interface IDoctorService
{ 
    Task<List<DoctorDTO>> GetAllDoctorsAsync();
}