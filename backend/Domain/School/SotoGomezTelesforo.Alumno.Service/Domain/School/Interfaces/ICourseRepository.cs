using SotoGomezTelesforo.Alumno.Service.Application.Dtos.Course;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using System.Threading.Tasks;

namespace SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCoursesAsync(CourseResourceParameters courseResourceParameters);
        Task<Course> GetCourseAsync(Guid courseId);
        Task AddCourseAsync(Course course);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(Course course);

    }
}
