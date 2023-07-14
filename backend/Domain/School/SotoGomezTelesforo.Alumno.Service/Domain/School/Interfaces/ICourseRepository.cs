using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using System.Threading.Tasks;

namespace SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCoursesAsync();
        Task<Course> GetCourseAsync(Guid courseId);
        Task AddCourseAsync(Course course);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(Course course);

    }
}
