using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Application.Mappers;
using SotoGomezTelesforo.Alumno.Service.Application.Services;

namespace SotoGomezTelesforo.Alumno.Service.Application.Extensions
{
    public static class ApplicationExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CourseMapper));
            services.AddScoped<ISchoolApplicationService, SchoolApplicationService>();

        }
    }
}
