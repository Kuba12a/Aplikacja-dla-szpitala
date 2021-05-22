using DoctorVisitsSelector.Dtos;
using DoctorVisitsSelector.Models;
using DoctorVisitsSelector.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.Controllers
{
    [ApiController]
    public class PatientVisitSelectorController : ControllerBase
    {
        private readonly ILogger<PatientVisitSelectorController> logger;
        private readonly IDoctorVisitSelectorHandler patientVisitSelectorHandler;

        public PatientVisitSelectorController(ILogger<PatientVisitSelectorController> logger, IDoctorVisitSelectorHandler patientVisitSelectorHandler)
        {
            this.logger = logger;
            this.patientVisitSelectorHandler = patientVisitSelectorHandler;
        }

        [HttpGet("Doctors-visits")]
        public async Task<IEnumerable<PatientVisitPairDto>> GetDoctorVisitsPairsbyPatientId([FromQuery] int doctorId)
        {
            return await patientVisitSelectorHandler.GetVisitsSelectionAsync(doctorId);
        }

        [HttpGet("Doctors-visitsByDate")]
        public async Task<IEnumerable<PatientVisitPairDto>> GetDoctorVisitsByDate([FromQuery] string date, [FromQuery] int doctorId)
        {
            return await patientVisitSelectorHandler.GetDoctorVisitsByDateAsync(date, doctorId);
        }

        [HttpGet("Doctors-visitsByClinic")]
        public async Task<IEnumerable<PatientVisitPairDto>> GetDoctorVisitsByClinic([FromQuery] string clinic, [FromQuery] int doctorId)
        {
            return await patientVisitSelectorHandler.GetDoctorVisitsByClinicAsync(clinic, doctorId);
        }
    }
}
