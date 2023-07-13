using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;

namespace SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(Student student);
        Task<bool> StudentExists(Guid studentId);
        Task DeleteStudentAsync(Student student);
        Task<Student> GetStudentAsync(Guid studentId);
        Task<List<Student>> GetStudentsAsync();
        Task<IEnumerable<Student>> GetStudentsAsync(List<Guid> studentIds);
        Task UpdateStudentAsync(Student Student);
    }
}
