using DoctorVisitsSelector.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.DataServiceClients
{
    public interface IPatientServiceClient
    {
        Task<IEnumerable<PatientDto>> GetAllPatients();

    }
}
