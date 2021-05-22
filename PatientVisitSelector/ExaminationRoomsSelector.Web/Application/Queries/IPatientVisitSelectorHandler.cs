namespace ExaminationRoomsSelector.Web.Application.Queries
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IPatientVisitSelectorHandler
    {
        Task<IEnumerable<DoctorVisitPairDto>> GetVisitsSelectionAsync(int id);
        Task<IEnumerable<DoctorVisitPairDto>> GetVisitsSelectionAsync(int id, string specialization);
        Task<IEnumerable<DoctorVisitPairDto>> GetVisitsbyDateSelectionAsync(int id, string date);
    }
}
