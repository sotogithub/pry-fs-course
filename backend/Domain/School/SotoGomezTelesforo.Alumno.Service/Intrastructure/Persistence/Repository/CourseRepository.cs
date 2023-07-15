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
        public async Task AddCourseAsync(Course course)
        {
            await _schoolDbContext.Courses.AddAsync(course);
        }

        public Task DeleteCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public async Task<Course> GetCourseAsync(Guid courseId)
        {
            return await _schoolDbContext.Courses.FirstOrDefaultAsync(c => c.Id.Equals(courseId));
        }

        public async Task<List<Course>> GetCoursesAsync()
        {
            var courses = await _schoolDbContext.Courses.ToListAsync();
            return courses;
        }

        public async Task UpdateCourseAsync(Course course)
        {
            var courseUpdate = await GetCourseAsync(course.Id);
            if (courseUpdate != null)
            {
                courseUpdate.CourseName = course.CourseName;
                courseUpdate.CourseDescription = course.CourseDescription;
                
            }
        }
    }
}
