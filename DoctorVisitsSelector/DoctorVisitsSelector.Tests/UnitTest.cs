using DoctorVisitsSelector.Algorithm;
using DoctorVisitsSelector.DataServiceClients;
using DoctorVisitsSelector.Dtos;
using DoctorVisitsSelector.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.Tests
{
    [TestClass]
    public class UnitTest
    {
        //private readonly VisitServiceClient visitsServiceClient = new VisitServiceClient();
        //private readonly PatientServiceClient patientsServiceClient = new PatientServiceClient();

        [TestMethod]
        public async Task TestGetVisitsSelectionAsync1()
        {
            PatientDto patient = new PatientDto(1,"Sebastian","Kapuczino", 178, "95231047956", "Male");

            //DateTime date = new DateTime(2022, 5, 29, 8, 0, 0);
            string date = "5/29/2022 8:00:00 AM";
            ClinicDto clinic = new ClinicDto("Warszawska 15", "ClinicMed");
            VisitDto visit = new VisitDto(1,1,date);
            visit.Clinic = clinic;

            List<PatientDto> patients = new List<PatientDto> {patient};
            List<VisitDto> visits = new List<VisitDto> {visit};

            Algo alg = new Algo();

            Task<IEnumerable<PatientVisitPairDto>> doctorVisitPairs =Task.FromResult(alg.DoAlgorythmAsync(patients, visits));
            IEnumerable<PatientVisitPairDto> pairs = await doctorVisitPairs;
            int len = 0;

            foreach (PatientVisitPairDto pair in pairs)
            {
                len++;
            }

            Assert.IsTrue(len==1);
        }

        [TestMethod]
        public async Task TestGetVisitsSelectionAsync2()
        {
            PatientDto patient = new PatientDto(1, "Sebastian", "Kapuczino", 178, "95231047956", "Male");

            //DateTime date = new DateTime(2022, 5, 29, 8, 0, 0);,
            string date = "5/29/2022 8:00:00 AM";
            ClinicDto clinic = new ClinicDto("Warszawska 15", "ClinicMed");
            VisitDto visit = new VisitDto(3, 3, date);
            visit.Clinic = clinic;

            List<PatientDto> patients = new List<PatientDto> { patient };
            List<VisitDto> visits = new List<VisitDto> { visit };

            Algo alg = new Algo();

            Task<IEnumerable<PatientVisitPairDto>> doctorVisitPairs = Task.FromResult(alg.DoAlgorythmAsync(patients, visits));
            IEnumerable<PatientVisitPairDto> pairs = await doctorVisitPairs;
            int len = 0;

            foreach (PatientVisitPairDto pair in pairs)
            {
                len++;
            }

            Assert.IsTrue(len == 0);
        }
    }
}
