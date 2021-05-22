using System;
using System.Collections.Generic;
using System.Linq;
using Visits.Domain;

namespace Visits.Infrastructures
{
    public class VisitRepository : IVisitRepository
    {
        const string Path = "VisitsRepo.xml";

        public IEnumerable<Visit> GetAll()
        {
            return XMLRead.ReadVisitsFromXML();
        }

        public IEnumerable<Visit> GetByDocId(int id)
        {
            return XMLRead.ReadVisitsFromXML()?.Where(ld => ld.DoctorId==id);
        }
        public IEnumerable<Visit> GetByPatId(int id)
        {
            return XMLRead.ReadVisitsFromXML()?.Where(ld => ld.PatientId == id);
        }

        public IEnumerable<Visit> GetByDateNPatientId(DateTime date, int id)
        {
            return GetByPatId(id).Where(Id => (Id.date.DayOfYear == date.DayOfYear & Id.date.Year== date.Year));
        }

        public IEnumerable<Visit> GetByDateNDoctorId(DateTime date, int id)
        {
            return GetByPatId(id).Where(Id => (Id.date.DayOfYear == date.DayOfYear & Id.date.Year == date.Year));
        }

        public IEnumerable<Visit> GetByClinicNDoctorId(string clinic, int id)
        {
            return GetByDocId(id).Where(Id => Id.clinic.Adress == clinic);
        }
    }
}
