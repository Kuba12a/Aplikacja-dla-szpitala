using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.Dtos
{
    public class PatientVisitPairDto
    {
        public PatientVisitPairDto(PatientDto patient, VisitDto visit)
        {
            this.Name = patient.Name;
            this.Surname = patient.Surname;
            this.date = visit.date;
            this.adres = visit.Clinic.Adress;
            this.clinicName = visit.Clinic.Name;
        }
        public string date { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string adres { get; set; }
        public string clinicName { get; set; }


    }
}
