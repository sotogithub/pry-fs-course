using AutoMapper;
using SotoGomezTelesforo.Alumno.Service.Application.Interfaces;
using SotoGomezTelesforo.Alumno.Service.Intrastructure.Persistence.UnitOfWork;

namespace SotoGomezTelesforo.Alumno.Service.Application.Services
{
    public partial class SchoolApplicationService : ISchoolApplicationService
    {
        private readonly SchoolUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IValidationService _validationService;
        public SchoolApplicationService(
            SchoolUnitOfWork unitOfWork,
            IMapper mapper,
            IValidationService validationService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validationService = validationService;
        }
    }
}
