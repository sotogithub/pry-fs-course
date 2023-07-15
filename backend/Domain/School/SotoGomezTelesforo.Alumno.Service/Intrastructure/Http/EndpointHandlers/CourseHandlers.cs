using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos;
using SotoGomezTelesforo.Alumno.Service.Application.Dtos.Course;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.EndpointHandlers
{
    public class CourseHandlers
    {
        public static async Task<IResult> GetResultAsync(
            [FromServices] ISchoolApplicationService schoolApplicationService,
            [AsParameters] CourseResourceParameters courseResourceParameters
            )
        {
            var courses = await schoolApplicationService.GetCourseAsync(courseResourceParameters);
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

        public static async Task<Results<BadRequest, UnprocessableEntity<List<ValidationResult>>, CreatedAtRoute<CourseDto>, Ok<CourseDto>>> CreateAuthorAsync(
            [FromServices] ISchoolApplicationService _schoolApplicationService,
            [FromBody] CourseForCreationDto course
        )
        {
            if (course == null)
            {
                return TypedResults.BadRequest();
            }

            var result = await _schoolApplicationService.CreateCourseAsync(course);
            if (!result.Success)
            {
                return TypedResults.UnprocessableEntity(result.ValidationErrors);
            }

            return TypedResults.CreatedAtRoute(result.Course, $"GetCourse", new { result.Course.Id });
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
