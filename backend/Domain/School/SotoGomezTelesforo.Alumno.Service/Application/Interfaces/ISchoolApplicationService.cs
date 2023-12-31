﻿using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos.Course;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Results;

namespace SotoGomezTelesforo.Alumno.Service.Application.Interfaces
{
    public interface ISchoolApplicationService
    {
        Task<List<CourseDto>> GetCourseAsync(CourseResourceParameters courseResourceParameters);
        Task<CourseDto> GetCourseByIdAsync(Guid Id);
        Task<CreateCourseResult> CreateCourseAsync(CourseForCreationDto course);
        Task<UpdateCourseResult> UpdateCourseAsync(Guid Id, CourseForUpdateDto course);
        Task<bool?> DeleteCourseAsync(Guid Id);

    }
}
