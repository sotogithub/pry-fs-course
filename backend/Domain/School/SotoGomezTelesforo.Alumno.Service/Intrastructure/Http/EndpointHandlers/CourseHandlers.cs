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

        public static async Task<Results<BadRequest, NotFound, NoContent, Ok<CourseDto>>> UpdateCourseAsync(
           [FromServices] ISchoolApplicationService _schoolApplicationService,
           [FromBody] CourseForUpdateDto course,
           Guid Id
        )
        {
            if (course == null)
            {
                return TypedResults.BadRequest();
            }

            var result = await _schoolApplicationService.UpdateCourseAsync(Id, course);

            if (result.Success && result.CourseUpserted != null)
            {
                return TypedResults.Ok(result.CourseUpserted);
            }

            return TypedResults.NoContent();
        }
        public static async Task<Results<NotFound, NoContent>> DeleteCourseAsync(
          [FromServices] ISchoolApplicationService _schoolApplicationService,
          Guid Id
       )
        {
            var result = await _schoolApplicationService.DeleteCourseAsync(Id);

            if (result == null)
            {
                return TypedResults.NotFound();
            }

            return TypedResults.NoContent();
        }
    }
}
