using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visits.Domain;
using Visits.Dtos;

namespace Visits.Mapper
{
    public static class Mapper
    {
        public static ClinicDto Map(this Clinic clinic)
        {
            if (clinic == null)
                return null;

            return new ClinicDto
            {
                Adress = clinic.Adress,
                Name = clinic.Name
        
            };
        }
        public static Clinic Map(this ClinicDto clinic)
        {
            if (clinic == null)
                return null;

            return new Clinic(clinic.Adress, clinic.Name);
        }

        public static VisitDto Map(this Visit visit)
        {
            if (visit == null)
                return null;

            return new VisitDto
            {
                Id = visit.Id,
                DoctorId = visit.DoctorId,
                PatientId = visit.PatientId,
                date = visit.date.ToString(),
                clinic = Map(visit.clinic)
                //clinicAdress = visit.clinic.Adress,
               // clinicName = visit.clinic.Name
                

            };
        }

        public static Visit Map(this VisitDto visit)
        {
            if (visit == null)
                return null;


            return new Visit(visit.Id,visit.DoctorId,visit.PatientId, DateTime.Parse(visit.date), Map(visit.clinic));

           // new Clinic(visit.clinicAdress, visit.clinicName)


        }

    }
}
