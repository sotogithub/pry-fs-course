using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos.Course;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Application.Validators;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Results;
using System.ComponentModel.DataAnnotations;

namespace SotoGomezTelesforo.Alumno.Service.Application.Services
{
    public partial class SchoolApplicationService : ISchoolApplicationService
    {
        public async Task<CreateCourseResult> CreateCourseAsync(CourseForCreationDto course)
        {
            CreateCourseResult result = new();
            var validationResult = _validationService.ValidateCourseCreation(course);
            if (!validationResult.IsValid)
            {
                result.Success = false;
                result.ValidationErrors.AddRange(validationResult.Errors.Select(e => new ValidationResult(e.ErrorMessage)));
                return result;
            }


            var courseEntity = _mapper.Map<Course>(course);

            await _unitOfWork._courseRepository.AddCourseAsync(courseEntity);

            if (!await _unitOfWork.SaveAsync())
            {
                throw new Exception("Creating an author failed on save.");
            }

            result.Course = _mapper.Map<CourseDto>(courseEntity);
            result.Success = true;
            return result;
        }

        public async Task<bool?> DeleteCourseAsync(Guid Id)
        {
            var courseFronRepo = await _unitOfWork._courseRepository.GetCourseAsync(Id);
            if (courseFronRepo == null)
            {
                return null;
            }

            await _unitOfWork._courseRepository.DeleteCourseAsync(courseFronRepo);

            if (!await _unitOfWork.SaveAsync())
            {
                throw new Exception($"Deleting course {Id} failed on save.");
            }

            return true;
        }

        public async Task<List<CourseDto>> GetCourseAsync(CourseResourceParameters courseResourceParameters)
        {
            var coursesFromRepo = await _unitOfWork._courseRepository.GetCoursesAsync(courseResourceParameters);
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
