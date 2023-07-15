using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.EndpointHandlers
{
    public class CourseHandlers
    {
        public static async Task<IResult> GetResultAsync(
            [FromServices] ISchoolApplicationService schoolApplicationService
            )
        {
            var courses = await schoolApplicationService.GetCourseAsync();
            return TypedResults.Ok( courses );
        }

        public static async Task<IResult> GeCourseByIdAsync(
            [FromServices] ISchoolApplicationService schoolApplicationService,
            Guid Id
            )
        {
            var courses = await schoolApplicationService.GetCourseByIdAsync(Id);
            return TypedResults.Ok(courses);
        }

        public static async Task<Results<BadRequest, Ok<CourseDto>>> CreateAuthorAsync(
            [FromServices] ISchoolApplicationService _schoolApplicationService,
            [FromBody] CourseForCreationDto course
        )
        {
            if (course == null)
            {
                return TypedResults.BadRequest();
            }

            var result = await _schoolApplicationService.CreateCourseAsync(course);
            return TypedResults.Ok(result);
        }
    }
}
