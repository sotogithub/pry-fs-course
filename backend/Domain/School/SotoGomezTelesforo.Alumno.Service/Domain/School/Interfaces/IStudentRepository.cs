using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;

namespace SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);
        Task AddStudentAsync(Student student);
        Task UpdateStudentAsync(Student Student);
        Task DeleteStudentAsync(Student student);

    }
}
