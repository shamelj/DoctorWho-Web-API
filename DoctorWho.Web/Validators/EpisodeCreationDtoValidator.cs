using DoctorWho.DB.Repositories;
using DoctorWho.Web.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace DoctorWho.Web.Validators;

public class EpisodeCreationDtoValidator : AbstractValidator<EpisodeCreationDto>
{
    public EpisodeCreationDtoValidator()
    {
        RuleFor(episode => episode.AuthorId).NotEmpty();
        RuleFor(episode => episode.DoctorId).NotEmpty();
        RuleFor(episode => episode.SeriesNumber)
            .Must(seriesNumber => seriesNumber.ToString().Length == 10)
            .WithMessage("SeriesNumber should be 10 characters long.");
        RuleFor(episode => episode.EpisodeNumber).GreaterThan(0);
    }
}