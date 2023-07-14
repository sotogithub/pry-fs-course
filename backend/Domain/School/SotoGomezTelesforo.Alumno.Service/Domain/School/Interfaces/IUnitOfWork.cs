namespace SotoGomezTelesforo.Alumno.Service.Domain.School.Interfaces
{
    public interface IUnitOfWork
    {
        void Dispose();
        Task<bool> SaveAsync();
    }
}
