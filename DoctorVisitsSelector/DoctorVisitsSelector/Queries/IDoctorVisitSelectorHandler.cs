using DoctorVisitsSelector.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.Queries
{
    public interface IDoctorVisitSelectorHandler
    {
        Task<IEnumerable<PatientVisitPairDto>> GetVisitsSelectionAsync(int id);
        Task<IEnumerable<PatientVisitPairDto>> GetDoctorVisitsByDateAsync(string date,  int doctorId);
        Task<IEnumerable<PatientVisitPairDto>> GetDoctorVisitsByClinicAsync(string clinic,  int doctorId);

    }
}
