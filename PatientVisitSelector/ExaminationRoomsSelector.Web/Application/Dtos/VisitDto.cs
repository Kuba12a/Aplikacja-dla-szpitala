namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    using PatientVisitSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class VisitDto
    {
        public VisitDto() { }

        public VisitDto(int doctorId, int patientId, string visitDate)
        {
            this.PatientId = patientId;
            this.DoctorId = doctorId;
            this.date = visitDate;
        }

        public string date { get; set; }
        public int DoctorId { get; set; }

        public int PatientId { get; set; }

        public ClinicDto clinic { get; set; }

    }
}
