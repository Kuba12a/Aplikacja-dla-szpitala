using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visits.Domain;

namespace Visits.Infrastructures
{
    public interface IVisitRepository
    {
        IEnumerable<Visit> GetAll();
        IEnumerable<Visit> GetByDocId(int id);
        IEnumerable<Visit> GetByPatId(int id);
        IEnumerable<Visit> GetByDateNPatientId(DateTime date, int id);
        IEnumerable<Visit> GetByDateNDoctorId(DateTime date, int id);
        IEnumerable<Visit> GetByClinicNDoctorId(string clinic, int id);

    }
}
