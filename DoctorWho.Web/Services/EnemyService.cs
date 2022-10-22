using AutoMapper;

namespace DoctorWho.Web.Services;

class EnemyService : IEnemyService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public EnemyService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> EnemyExists(int enemyId)
    {
        return await _unitOfWork.EnemyRepository.Exists(enemyId);
    }
}