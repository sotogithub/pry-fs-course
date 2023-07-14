using SotoGomezTelesforo.Alumno.Service.Intrastructure.Http.Extensions;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Extensions;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Extensions
{
    public class InfrastructureOptions
    {
        public string? ConnectionString { get; set; }
    }
    public static class InfrastructureExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, Action<InfrastructureOptions> configure)
        {
            var options = new InfrastructureOptions();
            configure(options);

            services.AddHttp();
            services.AddPersistence(opt => opt.ConnectionString = options.ConnectionString);
            //services.AddSecurity();
        }
    }
}
