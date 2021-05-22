using DoctorVisitsSelector.DataServiceClients;
using DoctorVisitsSelector.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorVisitsSelector.Algorithm;

namespace DoctorVisitsSelector.Queries
{
    public class DoctorVisitSelectorQueryHandler : IDoctorVisitSelectorHandler
    {
        private readonly IVisitServiceClient visitsServiceClient;
        private readonly IPatientServiceClient patientsServiceClient;

        public DoctorVisitSelectorQueryHandler(IVisitServiceClient visitsServiceClient, IPatientServiceClient doctorsServiceClient)
        {
            this.visitsServiceClient = visitsServiceClient;
            this.patientsServiceClient = doctorsServiceClient;
        }

        public async Task<IEnumerable<PatientVisitPairDto>> GetVisitsSelectionAsync(int id)
        {
            IEnumerable<PatientDto> patients = await patientsServiceClient.GetAllPatients();         
            IEnumerable<VisitDto> visits = await visitsServiceClient.GetAllDoctorVisitsAsync(id); 



            Algo alg = new Algo();
            Task<IEnumerable<PatientVisitPairDto>> doctorVisitPairs = Task.FromResult(alg.DoAlgorythmAsync(patients, visits));


            return await doctorVisitPairs;

        }

        public async Task<IEnumerable<PatientVisitPairDto>> GetDoctorVisitsByDateAsync(string date, int id)
        {
            IEnumerable<PatientDto> patients = await patientsServiceClient.GetAllPatients();

            //IEnumerable<VisitDto> visitstmp = await visitsServiceClient.GetAllDoctorVisitsAsync(id);
            //IEnumerable<VisitDto> visits = visitstmp.Where(id => id.VisitDate.Date == date.Date);
            IEnumerable<VisitDto> visits = await visitsServiceClient.GetAllDoctorVisitsByDateAsync(date, id);

            Algo alg = new Algo();
            Task<IEnumerable<PatientVisitPairDto>> doctorVisitPairs = Task.FromResult(alg.DoAlgorythmAsync(patients, visits));


            return await doctorVisitPairs;
        }
        public async Task<IEnumerable<PatientVisitPairDto>> GetDoctorVisitsByClinicAsync(string clinic, int id)
        {
            IEnumerable<PatientDto> patients = await patientsServiceClient.GetAllPatients();

            //IEnumerable<VisitDto> visitstmp = await visitsServiceClient.GetAllDoctorVisitsAsync(id);
            //IEnumerable<VisitDto> visits = visitstmp.Where(id => id.Clinic.Adress == clinic);  // jeszcze nie wiem czy to dziala
            IEnumerable<VisitDto> visits = await visitsServiceClient.GetAllDoctorVisitsByClinicAsync(clinic,id);

            Algo alg = new Algo();
            Task<IEnumerable<PatientVisitPairDto>> doctorVisitPairs = Task.FromResult(alg.DoAlgorythmAsync(patients, visits));


            return await doctorVisitPairs;
        }
    }
}
