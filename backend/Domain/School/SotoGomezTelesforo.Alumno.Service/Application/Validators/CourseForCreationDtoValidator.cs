using FluentValidation;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos;

namespace SotoGomezTelesforo.Alumno.Service.Application.Validators
{
    public class CourseForCreationDtoValidator : AbstractValidator<CourseForCreationDto>
    {
        public CourseForCreationDtoValidator()
        {
            RuleFor(x => x.CourseName).NotEmpty();
            RuleFor(x => x.CourseDescription).NotEmpty();
        }
    }
}
