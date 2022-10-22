namespace DoctorWho.Web.Services;

public interface ICompanionService
{
    Task<bool> Exists(int companionId);
}