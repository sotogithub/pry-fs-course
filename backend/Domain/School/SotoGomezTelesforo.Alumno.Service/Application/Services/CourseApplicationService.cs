using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;

namespace SotoGomezTelesforo.Alumno.Service.Application.Services
{
    public partial class SchoolApplicationService : ISchoolApplicationService
    {
        public async Task<List<CourseDto>> GetCourseAsync()
        {
            var coursesFromRepo = await _unitOfWork._courseRepository.GetCoursesAsync();
            var courses = _mapper.Map<List<CourseDto>>(coursesFromRepo);

            return courses;
        }

        public async Task<CourseDto> GetCourseByIdAsync(Guid Id)
        {
            var coursesFromRepo = await _unitOfWork._courseRepository.GetCourseAsync(Id);
            var courses = _mapper.Map<CourseDto>(coursesFromRepo);

            return courses;
        }
    }
}
