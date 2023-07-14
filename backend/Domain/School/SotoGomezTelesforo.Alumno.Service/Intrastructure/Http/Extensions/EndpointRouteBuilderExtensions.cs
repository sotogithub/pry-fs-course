using SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.EndpointHandlers;

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
        }

        public static void RegisterEndpoints(this IEndpointRouteBuilder app)
        {
            app.RegisterCoursesEndpoints();
        }
    }
}
