using ExaminationRoomsSelector.Web.Application.Algorithm;
using ExaminationRoomsSelector.Web.Application.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WebApp.Application;

//using WebApp.Application;

namespace PatientVisitSelectorTestProject
{
    [TestClass]
    public class UnitTest1
    {

        //Test metody DoAlgorythmAsync tworz¹cej pary lekarz-wizyta
        [TestMethod]
        public void TestMethod1()
        {
            Algorithm alg = new Algorithm();

            int id = 8888;

            IEnumerable<DoctorDto> doctors = new List<DoctorDto> { new DoctorDto(id, "Rudolf", "Rudolfowski", new List<string> { "pediatra" }, 1.8, "Male") };
            IEnumerable<VisitDto> visits = new List<VisitDto> { new VisitDto(id, id, "01/01/1999") };

            IList<DoctorVisitPairDto> pairs = (IList<DoctorVisitPairDto>)alg.DoAlgorythmAsync(doctors, visits);
            
            Assert.IsTrue(pairs[0].Name == "Rudolf" );
        }



        //Test metody DoAlgorythmAsync tworz¹cej pary lekarz-wizyta - brak danych lekarzy lub wizyt
        [TestMethod]
        public void TestMethod2()
        {
            Algorithm alg = new Algorithm();


            IEnumerable<DoctorDto> doctors = null;
            IEnumerable<VisitDto> visits = null;

            Action action = () => alg.DoAlgorythmAsync(doctors, visits);

            Assert.ThrowsException<NullReferenceException>(action, "Brak danych, blad ");
        }





    }
}
