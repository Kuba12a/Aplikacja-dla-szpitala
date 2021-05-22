namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApp.Application;

    public interface IDoctorsServiceClient
    {
        Task<IEnumerable<DoctorDto>> GetAllDoctors();
    }
}
