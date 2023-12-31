﻿using SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.EndpointHandlers;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Extensions
{
    public static class EndpointRouteBuilderExtensions
    {
        public static void RegisterCoursesEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
        {
            var coursesEndpoints = endpointRouteBuilder
                .MapGroup("api/courses")
                .WithTags("Courses");

            coursesEndpoints.MapGet("", CourseHandlers.GetResultAsync)
                .WithName("GetCourses")
                .WithOpenApi();

            coursesEndpoints.MapGet("/{Id}", CourseHandlers.GeCourseByIdAsync)
                .WithName("GetCourse")
                .WithOpenApi();

            coursesEndpoints.MapPost("", CourseHandlers.CreateAuthorAsync)
                .ProducesValidationProblem(422)
                .WithName("CreateCourse")
                .WithOpenApi();

            coursesEndpoints.MapPut("/{Id:guid}", CourseHandlers.UpdateCourseAsync)
                .WithName("UpdateCourse")
                .WithOpenApi();
            coursesEndpoints.MapDelete("/{Id:guid}", CourseHandlers.DeleteCourseAsync)
                .WithName("DeleteCourse")
                .WithOpenApi();
        }

        public static void RegisterEndpoints(this IEndpointRouteBuilder app)
        {
            app.RegisterCoursesEndpoints();
        }
    }
}
