namespace Visits.Controllers
{
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Visits.Domain;
using Visits.Dtos;
using Visits.Infrastructures;
using Visits.Mapper;
using Visits.Models;

    [ApiController]
    public class VisitsController : ControllerBase
    {
        private readonly ILogger<VisitsController> logger;
        private readonly IVisitQueryHandler visits;

        public VisitsController(ILogger<VisitsController> logger, IVisitQueryHandler visits)
        {
            this.logger = logger;
            this.visits = visits;
        }

        [HttpGet("GetVisits")]
        public IEnumerable<VisitDto> GetAll()
        {
            return visits.GetAll();
        }

      [HttpGet("GetVisits-ByDoctorId")]
        public IEnumerable<VisitDto> GetbyDocId([FromQuery] int id)
        {
            return visits.GetByDocId(id);
        }

      [HttpGet("GetVisits-ByPatientId")]
      public IEnumerable<VisitDto> GetbyPatId([FromQuery] int id)
      {
          return visits.GetByPatId(id);
      }
      [HttpGet("GetVisits-ByDateNPatientId")]
        public IEnumerable<VisitDto> GetByDateNPatientId([FromQuery] string date, [FromQuery] int id)
      {
            try
            {
                DateTime DTdate = DateTime.Parse(date);
            return visits.GetByDateNPatientId(DTdate,id);
            }
            catch (Exception e) { return null; }
        }

      [HttpGet("GetVisits-ByDateNDoctorId")]
        public IEnumerable<VisitDto> GetByDateNDoctorId([FromQuery] string date, [FromQuery] int id)
      {
            try
            {
                DateTime DTdate = DateTime.Parse(date);
                return visits.GetByDateNDoctorId(DTdate, id);
            }
            catch (Exception e) { return null; }
            
      }

      [HttpGet("GetVisits-ByClinicNDoctorId")]
        public IEnumerable<VisitDto> GetByClinicNDoctorId([FromQuery] string clinic, [FromQuery] int id)
      {
          return visits.GetByClinicNDoctorId(clinic,id);
      }
}
}
