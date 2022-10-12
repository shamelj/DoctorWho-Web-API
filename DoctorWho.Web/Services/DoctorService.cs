using AutoMapper;
using DoctorWho.DB.models;
using DoctorWho.DB.Repositories;
using DoctorWho.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Web.Services;

public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IMapper _mapper;

    public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
    {
        this._doctorRepository = doctorRepository;
        _mapper = mapper;
    }
    public async Task<List<DoctorDto>> GetAllDoctorsAsync()
    {
        var doctors = _doctorRepository.GetDoctors();
        return await doctors
                .Select(doctorEntity => _mapper.Map<DoctorDto>(doctorEntity))
                .ToListAsync();
    }

    public async Task<DoctorDto> CreateDoctor(DoctorDto doctorDto)
    {
        var doctorEntity =  _doctorRepository.AddDoctorAsync(_mapper.Map<Doctor>(doctorDto));
        await _doctorRepository.SaveChangesAsync();
        return _mapper.Map<DoctorDto>(doctorEntity);
    }

    public async Task<bool> DoctorExists(int id)
    {
        return await _doctorRepository.DoctorExists(id);
    }
    public async Task<DoctorDto> UpdateDoctorAsync(int id, DoctorDto doctorDto)
    {
        var doctorEntity = await _doctorRepository.UpdateDoctorAsync(id,_mapper.Map<Doctor>(doctorDto));
        await _doctorRepository.SaveChangesAsync();
        return _mapper.Map<DoctorDto>(doctorEntity);
    }
}