using Microsoft.EntityFrameworkCore;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Contexts;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolDbContext _schoolDbContext;

        public CourseRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }
        public Task AddCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetCourseAsync(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Course>> GetCoursesAsync()
        {
            var courses = await _schoolDbContext.Courses.ToListAsync();
            return courses;
        }

        public Task UpdateCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
