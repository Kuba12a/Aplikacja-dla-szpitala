using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visits.Dtos;

namespace Visits.Domain
{
    public interface IVisitQueryHandler
    {
        IEnumerable<VisitDto> GetAll();
        IEnumerable<VisitDto> GetByDocId(int id);
        IEnumerable<VisitDto> GetByPatId(int id);
        IEnumerable<VisitDto> GetByDateNPatientId(DateTime date, int id);
        IEnumerable<VisitDto> GetByDateNDoctorId(DateTime date, int id);
        IEnumerable<VisitDto> GetByClinicNDoctorId(string clinic, int id);

    }
}
