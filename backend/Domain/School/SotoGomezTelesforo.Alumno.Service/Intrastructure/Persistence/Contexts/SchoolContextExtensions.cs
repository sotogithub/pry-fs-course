using Microsoft.EntityFrameworkCore;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Contexts
{
    public partial class SchoolDbContext : DbContext
    {
        public void EnsureSeedDataForContext()
        {
            try
            {
                Database.EnsureDeleted();
                Database.Migrate();
                SaveChanges();

                List<Enrollment> enrollments = new List<Enrollment>()
            {
                new Enrollment()
                {
                    Id = new Guid("0a6844a2-029b-41f0-87e1-0a8d63936343"),
                    Student = new Student()
                    {
                        Id = new Guid("809ab9c4-4cbf-476c-b9d5-98268499f180"),
                        FirstName = "Percy",
                        LastName = "Soto Gomez",
                        Age = 26,
                        DateOfBirth = new DateTime(1996, 8,23),
                        Address = "Av. Miguel iglesias nro 23",
                        Email = "percysg369@gmail.com",
                        Phone = "123123123"
                    },
                    Course = new Course()
                    {
                        Id= new Guid("a62a5afd-0a14-4d61-bfea-bac5b9d8b8cb"),
                        CourseName = "Full-stack",
                        CourseDescription = ".Net 7 y angular 16"
                    },
                    EnrollmentDate = DateTime.Now
                },
                
                new Enrollment()
                {
                    Id = new Guid("1e2be809-7e4e-41a9-90a9-7bdb89463a29"),
                    Student = new Student()
                    {
                        Id = new Guid("0be018b2-8294-41fe-8445-d53abf756960"),
                        FirstName = "Juan",
                        LastName = "Flores Ramos",
                        Age = 26,
                        DateOfBirth = new DateTime(1996, 8,23),
                        Address = "Lince nro 23",
                        Email = "juan@gmail.com",
                        Phone = "123123123"
                    },
                    Course = new Course()
                    {
                        Id= new Guid("7022de6a-75d3-4b47-b6eb-973d02cd748b"),
                        CourseName = "Microservicios",
                        CourseDescription = ".Net 7 api minimal y angular 16"
                    },
                    EnrollmentDate = DateTime.Now
                },
                new Enrollment()
                {
                    Id = new Guid("7022de6a-75d3-4b47-b6eb-973d02cd748b"),
                    Student = new Student()
                    {
                        Id = new Guid("aa47d181-25f5-434b-9196-76dc7725dd61"),
                        FirstName = "Katy",
                        LastName = "Sanchez Mejia",
                        Age = 26,
                        DateOfBirth = new DateTime(1996, 8,23),
                        Address = "Callao nro 23",
                        Email = "katy@gmail.com",
                        Phone = "123123123"
                    },
                    Course = new Course()
                    {
                        Id= new Guid("3126f5f5-eea7-4d47-bc90-d46b5ffa25df"),
                        CourseName = "Javascript",
                        CourseDescription = "NodeJS, TypeScript"
                    },
                    EnrollmentDate = DateTime.Now
                },
                new Enrollment()
                {
                    Id = new Guid("7fb02755-4d08-4ed6-90a0-9c5b56fd7dbb"),
                    StudentId = new Guid("809ab9c4-4cbf-476c-b9d5-98268499f180"),
                    CourseId = new Guid("7022de6a-75d3-4b47-b6eb-973d02cd748b"),
                    EnrollmentDate = DateTime.Now
                },

            };

                Enrollments.AddRange(enrollments);
                SaveChanges();
            }
            catch (Exception ex)
            {
                var msn = ex.Message.ToString();
                throw;
            }
           
        }
    }
}
