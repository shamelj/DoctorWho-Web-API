using AutoMapper;

namespace DoctorWho.Web.Services;

class CompanionService : ICompanionService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CompanionService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> Exists(int companionId)
    {
        return await _unitOfWork.CompanionRepository.Exists(companionId);
    }
}