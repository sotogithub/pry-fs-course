using SotoGomezTelesforo.Alumno.Service.Application.Dtos;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Results
{
    public class UpdateCourseResult
    {
        public CourseDto CourseUpserted { get; set; }
        public bool Success { get; set; }
    }
}
