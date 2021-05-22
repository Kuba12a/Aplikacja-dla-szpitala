using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.Dtos
{
    public class VisitDto
    {
        public VisitDto() { }

        public VisitDto(int doctorId, int patientId, string date)
        {
            this.PatientId = patientId;
            this.DoctorId = doctorId;
            this.date = date;
        }

        public string date { get; set; }
        public int DoctorId { get; set; }

        public int PatientId { get; set; }

        public ClinicDto Clinic { get; set; }

    }
}
