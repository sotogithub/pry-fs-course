using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using System.Threading.Tasks;

namespace SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces
{
    public interface ICourseRepository
    {
        Task AddCourseAsync(Course course);
        Task<bool> CourseExists(Guid courseId);
        Task DeleteCourseAsync(Course course);
        Task<Course> GetCourseAsync(Guid courseId);
        Task<List<Course>> GetCoursesAsync();
        Task<IEnumerable<Course>> GetCoursesAsync(List<Guid> courseIds);
        Task UpdateCourseAsync(Course course);
    }
}
