using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Results;

namespace SotoGomezTelesforo.Alumno.Service.Application.Services
{
    public partial class SchoolApplicationService : ISchoolApplicationService
    {
        public async Task<CourseDto> CreateCourseAsync(CourseForCreationDto course)
        {
            var courseEntity = _mapper.Map<Course>(course);

            await _unitOfWork._courseRepository.AddCourseAsync(courseEntity);

            if (!await _unitOfWork.SaveAsync())
            {
                throw new Exception("Creating an author failed on save.");
            }

            var authorToReturn = _mapper.Map<CourseDto>(courseEntity);
            return authorToReturn;
        }

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

        public async Task<UpdateCourseResult> UpdateCourseAsync(Guid Id, CourseForUpdateDto course)
        {
            UpdateCourseResult result = new();
            var courseFromRepo = await _unitOfWork._courseRepository.GetCourseAsync(Id);

            
            _mapper.Map(course, courseFromRepo);
            await _unitOfWork._courseRepository.UpdateCourseAsync(courseFromRepo);
            if (!await _unitOfWork.SaveAsync())
            {
                throw new Exception($"Updating author {Id} failed on save.");
            }

            result.Success = true;
            result.CourseUpserted = _mapper.Map<CourseDto>(courseFromRepo);
            return result;
        }
    }
}
