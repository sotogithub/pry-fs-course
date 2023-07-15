using FluentValidation.Results;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos;

namespace SotoGomezTelesforo.Alumno.Service.Application.Interfaces
{
    public interface IValidationService
    {
        ValidationResult ValidateCourseCreation(CourseForCreationDto dto);
        //ValidationResult ValidateAuthorCreationWithDateOfDeath(AuthorForCreationWithDateOfDeathDto dto);
        //ValidationResult ValidateAuthorUpdate(AuthorForUpdateDto dto);
    }
}
