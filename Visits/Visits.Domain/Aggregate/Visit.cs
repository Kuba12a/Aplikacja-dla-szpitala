using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Visits.Domain
{

    public class Visit
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public DateTime date { get; set; }

        public Clinic clinic { get; set; }
        public Visit(int id, int docId, int patId, DateTime dt, Clinic clinic)
        {
            this.Id = id;
            this.DoctorId = docId;
            this.PatientId = patId;
            this.date = dt;
            this.clinic = clinic;


        }

    }
}
