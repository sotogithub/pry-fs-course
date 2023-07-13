﻿using Microsoft.EntityFrameworkCore;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Contexts;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Extensions
{
    public class PersistenceOptions
    {
        public string? ConnectionString { get; set; }
    }

    public static class PersistenceExtension
    {
        public static void UseSeedData(this IHost app)
        {
            var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
            using (var scope = scopedFactory!.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<SchoolDbContext>();
                context.EnsureSeedDataForContext();
            }
        }
        public static void AddPersistence(this IServiceCollection services, Action<PersistenceOptions> configure)
        {
            var options = new PersistenceOptions();
            configure(options);

            services.AddDbContext<SchoolDbContext>(o => o.UseSqlServer(options.ConnectionString));
            //services.AddScoped<IAuthorRepository, AuthorRepository>();
            //services.AddScoped<IBookRepository, BookRepository>();
            //services.AddScoped<LibraryUnitOfWork>();
            //services.AddTransient<IAuthorPropertyMappingService, AuthorPropertyMappingService>();
            //services.AddScoped<ITypeHelperService, TypeHelperService>();
        }
    }
}