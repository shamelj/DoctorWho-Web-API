using AutoMapper;
using DoctorWho.DB.Repositories;
using DoctorWho.Web.Controllers;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Web.Services;

class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IMapper _mapper;

    public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
    {
        this._doctorRepository = doctorRepository;
        _mapper = mapper;
    }
    public async Task<List<DoctorDTO>> GetAllDoctorsAsync()
    {
        var doctors = _doctorRepository.GetDoctors();
        return await doctors
                .Select(doctorEntity => _mapper.Map<DoctorDTO>(doctorEntity))
                .ToListAsync();
    }
}