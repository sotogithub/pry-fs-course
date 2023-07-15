using FluentValidation.AspNetCore;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Application.Mappers;
using SotoGomezTelesforo.Alumno.Service.Application.Services;
using SotoGomezTelesforo.Alumno.Service.Application.Validators;

namespace SotoGomezTelesforo.Alumno.Service.Application.Extensions
{
    public static class ApplicationExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CourseMapper));
            services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CourseForCreationDtoValidator>());
            services.AddTransient<IValidationService, ValidationService>();
            services.AddScoped<ISchoolApplicationService, SchoolApplicationService>();

        }
    }
}
