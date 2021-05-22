namespace ExaminationRoomsSelector.Web.Application.Queries
{
    using ExaminationRoomsSelector.Web.Application.DataServiceClients;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Algorithm;
    using System.Threading.Tasks;
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using WebApp.Application;

    public class PatientVisitSelectorQueryHandler : IPatientVisitSelectorHandler
    {
        private readonly IVisitServiceClient visitsServiceClient;
        private readonly IDoctorsServiceClient doctorsServiceClient;

        public PatientVisitSelectorQueryHandler(IVisitServiceClient visitsServiceClient, IDoctorsServiceClient doctorsServiceClient)
        {
            this.visitsServiceClient = visitsServiceClient;
            this.doctorsServiceClient = doctorsServiceClient;
        }

        public async Task<IEnumerable<DoctorVisitPairDto>> GetVisitsSelectionAsync(int id)
        {

            
            IEnumerable<DoctorDto> doctors = await doctorsServiceClient.GetAllDoctors();         //Wszyscy lekarze

            
            
            IEnumerable<VisitDto> visits = await visitsServiceClient.GetAllPatientVisitsAsync(id); //Wszystkie wizyty jednego pacjenta

            Algorithm alg = new Algorithm();
            Task<IEnumerable<DoctorVisitPairDto>> doctorVisitPairs =  Task.FromResult(alg.DoAlgorythmAsync(doctors, visits));

           
            return await doctorVisitPairs;

        }

        public async Task<IEnumerable<DoctorVisitPairDto>> GetVisitsSelectionAsync(int id,string specialization)
        {


            IEnumerable<DoctorDto> doctors = await doctorsServiceClient.GetAllDoctors();         //Wszyscy lekarze



            IEnumerable<VisitDto> visits = await visitsServiceClient.GetAllPatientVisitsAsync(id); //Wszystkie wizyty jednego pacjenta

            Algorithm alg = new Algorithm();
            Task<IEnumerable<DoctorVisitPairDto>> doctorVisitPairs = Task.FromResult(alg.DoAlgorythmAsync(doctors, visits)?.Where(ld => ld.Specialization.Contains(specialization)));


            return await doctorVisitPairs;

        }

        public async Task<IEnumerable<DoctorVisitPairDto>> GetVisitsbyDateSelectionAsync(int id, string date)
        {


            IEnumerable<DoctorDto> doctors = await doctorsServiceClient.GetAllDoctors();         //Wszyscy lekarze



            IEnumerable<VisitDto> visits = await visitsServiceClient.GetAllPatientVisitsByDateAsync(date, id); //Wszystkie wizyty jednego pacjenta

            Algorithm alg = new Algorithm();
            Task<IEnumerable<DoctorVisitPairDto>> doctorVisitPairs = Task.FromResult(alg.DoAlgorythmAsync(doctors, visits));


            return await doctorVisitPairs;

        }
    }
}
