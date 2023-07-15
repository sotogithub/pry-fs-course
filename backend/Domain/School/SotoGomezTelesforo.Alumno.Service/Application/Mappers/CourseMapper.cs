using AutoMapper;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;

namespace SotoGomezTelesforo.Alumno.Service.Application.Mappers
{
    public class CourseMapper : Profile
    {
        public CourseMapper()
        {
            CreateMap<Course, CourseDto>();
            CreateMap<CourseForCreationDto, Course>();
        }
    }
}
