using DoctorWho.Web.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace DoctorWho.Web.Validators;

public class DoctorCreationDtoValidator : AbstractValidator<DoctorCreationDto>
{
    public DoctorCreationDtoValidator()
    {
        RuleFor(doctor => doctor.Number).NotEmpty();
        RuleFor(doctor => doctor.Name).NotEmpty();
        RuleFor(doctor => doctor.LastEpisodeDate)
            .Empty()
            .When((_, context) => !context.InstanceToValidate.FirstEpisodeDate.HasValue);
        RuleFor(doctor => doctor.LastEpisodeDate).GreaterThanOrEqualTo(doctor => doctor.FirstEpisodeDate);
    }
}