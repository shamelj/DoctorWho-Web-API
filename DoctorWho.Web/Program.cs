using DoctorWho.DB;
using DoctorWho.DB.Repositories;
using DoctorWho.Web.Filters;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using DoctorWho.Web.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => options.Filters.Add<ModelStateFilter>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// AutoMapper configuration
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Adding Services
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddDbContext<DoctorWhoCoreDbContext>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
//validation
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScoped<IValidator<DoctorCreationDto>, DoctorCreationDtoValidator>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
