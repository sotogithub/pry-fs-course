using SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Contexts;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.UnitOfWork
{
    public class SchoolUnitOfWork : UnitOfWork
    {
        public ICourseRepository? _courseRepository { get; }
        public IStudentRepository? _studentRepository { get; }

        public SchoolDbContext _context { get; }

        public SchoolUnitOfWork(
            ICourseRepository? courseRepository, 
            IStudentRepository? studentRepository, 
            SchoolDbContext context) : base(context)
        {
            _courseRepository = courseRepository;
            _studentRepository = studentRepository;
            _context = context;
        } 
    }
}
