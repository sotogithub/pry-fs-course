using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;

namespace SotoGomezTelesforo.Alumno.Service.Application.Interfaces
{
    public interface ISchoolApplicationService
    {
        Task<List<CourseDto>> GetCourseAsync();
        Task<CourseDto> GetCourseByIdAsync(Guid Id);
    }
}
