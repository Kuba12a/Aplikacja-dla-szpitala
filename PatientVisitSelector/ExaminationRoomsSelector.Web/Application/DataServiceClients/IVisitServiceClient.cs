namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IVisitServiceClient
    {
        Task<IEnumerable<VisitDto>> GetAllPatientVisitsAsync(int id);

        Task<IEnumerable<VisitDto>> GetAllPatientVisitsByClinicAsync(string clinicAdress, int id);

        Task<IEnumerable<VisitDto>> GetAllPatientVisitsByDateAsync(string date, int id);
    }
}
