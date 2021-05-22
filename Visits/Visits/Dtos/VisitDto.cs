using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visits.Dtos
{
    public class VisitDto
    {
        public VisitDto()
        {

        }
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public string date { get; set; }
        public ClinicDto clinic { get; set; }
       // public string clinicAdress { get; set; }
       // public string clinicName { get; set; }
    }
}
