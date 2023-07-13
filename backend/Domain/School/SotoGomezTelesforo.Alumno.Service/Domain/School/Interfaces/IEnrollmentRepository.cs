using SotoGomezTelesforo.Alumno.Service.Domain.School.Entities;

namespace SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces
{
    public interface IEnrollmentRepository
    {
        
        Task AddEnrollmentAsync(Enrollment Enrollment);
        Task DeleteEnrollmentAsync(Enrollment Enrollment);
        Task<Enrollment> GetEnrollmentAsync(Guid studentId, Guid courseId, Guid EnrollmentId);
        Task<List<Enrollment>> GetEnrollmentAsync();
        Task<Enrollment> UpdateEnrollmentAsync(Enrollment enrollment);
        Task UpdateEnrollmentAsync(Guid enrollmentId,Enrollment enrollment);
    }
}
