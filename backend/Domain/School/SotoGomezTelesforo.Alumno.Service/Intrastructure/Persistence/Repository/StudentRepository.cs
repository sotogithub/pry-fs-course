using Microsoft.EntityFrameworkCore;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;
using SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Contexts;

namespace SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _schoolDbContext;

        public StudentRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public async Task AddStudentAsync(Student student)
        {
            await _schoolDbContext.Students.AddAsync(student);
        }

        public async Task DeleteStudentAsync(Student student)
        {
            await Task.FromResult(_schoolDbContext.Students.Remove(student));
        }

        public async Task<Student> GetStudentAsync(Guid studentId)
        {
            return await _schoolDbContext.Students.FirstOrDefaultAsync(c => c.Id.Equals(studentId));
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            var students = await _schoolDbContext.Students.ToListAsync();
            return students;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync(List<Guid> studentIds)
        {
            return await _schoolDbContext.Students.Where(c => studentIds.Contains(c.Id))
                .OrderBy(c => c.FirstName)
                .OrderBy(c => c.LastName)
                .ToListAsync();
        }

        public async Task<bool> StudentExists(Guid studentId)
        {
            return await _schoolDbContext.Students.AnyAsync(c => c.Id == studentId);
        }

        public async Task UpdateStudentAsync(Student Student)
        {
            var studentUpdate = await GetStudentAsync(Student.Id);
            if (studentUpdate != null)
            {
                studentUpdate.FirstName = Student.FirstName;
                studentUpdate.LastName = Student.LastName;
                studentUpdate.Age = Student.Age;
                studentUpdate.DateOfBirth = Student.DateOfBirth;
                studentUpdate.Address   = Student.Address;
                studentUpdate.Email = Student.Email;
                studentUpdate.Phone = Student.Phone;
            }
        }
    }
}
