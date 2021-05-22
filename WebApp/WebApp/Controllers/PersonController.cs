using Doctors.Domain;
using Doctors.Infrastractures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Application;
using WebApp.Application.Dtos;
using WebApp.Application.Mapper;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        

        private DoctorRepo doctorRepo = new DoctorRepo();
        private PatientRepo patientRepo = new PatientRepo();

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Doctors")]
        public IEnumerable<DoctorDto> GetDoctors()
        {
            return doctorRepo.GetAll().Select(r => r.Map());
        }

        [HttpGet("Patients")]
        public IEnumerable<PatientDto> GetPatients()
        {
            return patientRepo.GetAll().Select(r => r.Map());
        }

        [HttpGet("Doctors-Id")]
        public IEnumerable<DoctorDto> GetbySpecialization([FromQuery] int id)
        {
            return doctorRepo.GetById(id).Select(r => r.Map());
        }

        [HttpGet("Patients-Id")]
        public IEnumerable<PatientDto> GetbyId([FromQuery] int id)
        {
            return patientRepo.GetById(id).Select(r => r.Map());
        }

        [HttpPost("AddDoctor")]
        public DoctorDto AddDoctor([FromQuery] DoctorDto doctor)
        {
            doctorRepo.AddDoctor(Mapper.Map(doctor));
            return doctor;
        }
        [HttpPost("AddPatient")]
        public PatientDto AddPatient([FromQuery] PatientDto patient)
        {
            patientRepo.AddPatient(Mapper.Map(patient));
            return patient;
        }


    }
}
