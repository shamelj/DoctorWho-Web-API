using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DoctorDTO>>> GetAllDoctors([FromQuery] long? pageNo, [FromQuery] long pageSize)
        {
            return Ok(await _doctorService.GetAllDoctorsAsync());
        }
    }
}
