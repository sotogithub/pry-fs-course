using AutoMapper;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.UnitOfWork;

namespace SotoGomezTelesforo.Alumno.Service.Application.Services
{
    public partial class SchoolApplicationService : ISchoolApplicationService
    {
        private readonly SchoolUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SchoolApplicationService(
            SchoolUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
