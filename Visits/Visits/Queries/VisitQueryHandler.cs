using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visits.Dtos;
using Visits.Mapper;
using Visits.Infrastructures;

namespace Visits.Domain
{
    public class VisitQueryHandler : IVisitQueryHandler
    {
        private readonly IVisitRepository visitRepository;
        public VisitQueryHandler(IVisitRepository visitRepository)
        {
            this.visitRepository = visitRepository;
        }
        public IEnumerable<VisitDto> GetAll()
        {
            return visitRepository.GetAll().Select(r=>r.Map());
        }
        public IEnumerable<VisitDto> GetByDocId(int id)
        {
            return visitRepository.GetByDocId(id).Select(r => r.Map());
        }

        public IEnumerable<VisitDto> GetByPatId(int id)
        {
            return visitRepository.GetByPatId(id).Select(r => r.Map());
        }
       
        public IEnumerable<VisitDto> GetByDateNPatientId(DateTime date, int id)
        {
            return visitRepository.GetByDateNPatientId(date,id).Select(r => r.Map());
        }

        public IEnumerable<VisitDto> GetByDateNDoctorId(DateTime date, int id)
        {
            return visitRepository.GetByDateNDoctorId(date,id).Select(r => r.Map());
        }

        public IEnumerable<VisitDto> GetByClinicNDoctorId(string clinic, int id)
        {
            return visitRepository.GetByClinicNDoctorId(clinic,id).Select(r => r.Map());
        }
    }
}
