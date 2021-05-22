using ExaminationRoomsSelector.Web.Application.Dtos;
using ExaminationRoomsSelector.Web.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Application;

namespace ExaminationRoomsSelector.Web.Controllers
{
    
    public class PatientVisitSelectorController : ControllerBase
    {
        private readonly ILogger<PatientVisitSelectorController> logger;
        private readonly IPatientVisitSelectorHandler doctorVisitSelectorHandler;

        public PatientVisitSelectorController(ILogger<PatientVisitSelectorController> logger, IPatientVisitSelectorHandler doctorVisitSelectorHandler)
        {
            this.logger = logger;
            this.doctorVisitSelectorHandler = doctorVisitSelectorHandler;
        }

        [HttpGet("patients-visits")]
        public async Task<IEnumerable<DoctorVisitPairDto>> GetDoctorVisitsPairsbyPatientId([FromQuery] int patientId)
        {
            return await doctorVisitSelectorHandler.GetVisitsSelectionAsync(patientId);
        }

        [HttpGet("patients-visits-bySpecialization")]
        public async Task<IEnumerable<DoctorVisitPairDto>> GetDoctorVisitsPairsByPatientIdBySpecialization([FromQuery] int patientId, string specialization)
        {
            return await doctorVisitSelectorHandler.GetVisitsSelectionAsync(patientId, specialization);
        }

        [HttpGet("patients-visits-byDate")]
        public async Task<IEnumerable<DoctorVisitPairDto>> GetDoctorVisitsPairsByPatientIdByDate([FromQuery] int patientId, string date)
        {
            return await doctorVisitSelectorHandler.GetVisitsbyDateSelectionAsync(patientId, date);
        }

        /*
        [HttpGet("doctor-visit-selection")]
        public async Task<IEnumerable<DoctorVisitPairDto>> GetLaboratoryDiagnosticiansDetails()
        {
            return await doctorVisitSelectorHandler.GetVisitsSelectionAsync();
        }*/
    }
}
