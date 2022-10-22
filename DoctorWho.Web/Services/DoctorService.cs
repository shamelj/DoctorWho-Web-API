using AutoMapper;
using DoctorWho.DB.models;
using DoctorWho.DB.Repositories;
using DoctorWho.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Web.Services;

public class DoctorService : IDoctorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DoctorService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<List<DoctorDto>> GetAllDoctorsAsync()
    {
        var doctors = await _unitOfWork.DoctorRepository.GetDoctorsAsync();
        return doctors
            .Select(doctorEntity => _mapper.Map<DoctorDto>(doctorEntity))
            .ToList();
    }

    public async Task<DoctorDto> CreateDoctor(DoctorDto doctorDto)
    {
        _unitOfWork.DoctorRepository.AddDoctor(_mapper.Map<Doctor>(doctorDto));
        await _unitOfWork.SaveChangesAsync();
        var insertedDoctor = await _unitOfWork.DoctorRepository.GetDoctorAsync(doctorDto.Id);
        return _mapper.Map<DoctorDto>(insertedDoctor);
    }

    public async Task<bool> DoctorExists(int id)
    {
        return await _unitOfWork.DoctorRepository.DoctorExists(id);
    }
    public async Task<DoctorDto> UpdateDoctorAsync(DoctorDto doctorDto)
    {
        _unitOfWork.DoctorRepository.UpdateDoctor(_mapper.Map<Doctor>(doctorDto));
        await _unitOfWork.SaveChangesAsync();
        var updatedDoctor = await _unitOfWork.DoctorRepository.GetDoctorAsync(doctorDto.Id);
        return _mapper.Map<DoctorDto>(updatedDoctor);
    }

    public async Task DeleteDoctor(int id)
    {
        _unitOfWork.DoctorRepository.DeleteDoctor(id);
        await _unitOfWork.SaveChangesAsync();
    }
}