using FluentValidation;
using FluentValidation.Results;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;

namespace SotoGomezTelesforo.Alumno.Service.Application.Validators
{
    public class ValidationService : IValidationService
    {
        private readonly IValidator<CourseForCreationDto> _courseCreationValidator;

        public ValidationService(
            IValidator<CourseForCreationDto> courseCreationValidator
            )
        {
            _courseCreationValidator = courseCreationValidator;
        }

        public ValidationResult ValidateCourseCreation(CourseForCreationDto dto)
        {
            return _courseCreationValidator.Validate( dto );
        }

        
    }
}
