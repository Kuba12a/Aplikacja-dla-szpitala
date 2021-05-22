using DoctorVisitsSelector.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.DataServiceClients
{
    public interface IVisitServiceClient
    {
        Task<IEnumerable<VisitDto>> GetAllDoctorVisitsAsync(int id);
        Task<IEnumerable<VisitDto>> GetAllDoctorVisitsByDateAsync(string date, int id);
        Task<IEnumerable<VisitDto>> GetAllDoctorVisitsByClinicAsync(string clinicAdress, int id);

    }
}
