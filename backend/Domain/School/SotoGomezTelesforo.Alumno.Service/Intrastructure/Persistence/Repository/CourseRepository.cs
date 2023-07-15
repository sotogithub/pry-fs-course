using Microsoft.EntityFrameworkCore;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos.Course;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Contexts;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolDbContext _context;

        public CourseRepository(SchoolDbContext schoolDbContext)
        {
            _context = schoolDbContext;
        }
        public async Task AddCourseAsync(Course course)
        {
            await _context.Courses.AddAsync(course);
        }

        public async Task DeleteCourseAsync(Course course)
        {
            await Task.FromResult(_context.Courses.Remove(course));
        }

        public async Task<Course> GetCourseAsync(Guid courseId)
        {
            return await _context.Courses.FirstOrDefaultAsync(c => c.Id.Equals(courseId));
        }

        public async Task<List<Course>> GetCoursesAsync(CourseResourceParameters courseResourceParameters)
        {
            //var courses = await _context.Courses.ToListAsync();
            //return courses;
            var queryAuthors = _context.Courses.AsQueryable();

            

            if (!string.IsNullOrEmpty(courseResourceParameters.SearchQuery))
            {
                var searchQueryForWhereClause = courseResourceParameters.SearchQuery.Trim().ToLower();

                queryAuthors = queryAuthors
                    .Where(a => a.CourseName.ToLower().Contains(searchQueryForWhereClause)
                    || a.CourseDescription.ToLower().Contains(searchQueryForWhereClause));
            }

            return queryAuthors.ToList();
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
