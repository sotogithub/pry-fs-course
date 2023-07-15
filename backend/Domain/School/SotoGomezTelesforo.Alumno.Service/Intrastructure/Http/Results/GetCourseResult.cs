using SotoGomezTelesforo.Alumno.Service.Application.Dtos;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Results
{
    public class GetCourseResult
    {
        public List<CourseDto> Courses { get; set; }
    }
}
