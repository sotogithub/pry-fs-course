using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using System.ComponentModel.DataAnnotations;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Results
{
    public class CreateCourseResult
    {
        public CourseDto Course { get; set; }
        public List<ValidationResult> ValidationErrors { get; set; } = new();
        public bool Success { get; set; }
    }
}
