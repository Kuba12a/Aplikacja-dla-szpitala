using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Visits.Domain;
using Visits.Dtos;
using Visits.Infrastructures;


namespace Visits.Tests
{
    [TestClass]
    public class UnitTests
    {
        static VisitRepository visitRepository = new VisitRepository();
        static VisitQueryHandler queryHandler = new VisitQueryHandler(visitRepository);

        [TestMethod]
        public void TestGetAll()
        {
            IEnumerable<VisitDto> visitList = queryHandler.GetAll();

            Assert.IsTrue(visitList.Count() == 1);
        }

        [TestMethod]
        public void TestGetByDocId1()
        {
            IEnumerable<VisitDto> visitList = queryHandler.GetByDocId(1);

            Assert.IsTrue(visitList.Count() == 1);
        }

        [TestMethod]
        public void TestGetByDocId2()
        {
            IEnumerable<VisitDto> visitList = queryHandler.GetByDocId(2);

            Assert.IsTrue(visitList.Count() == 0);
        }

        [TestMethod]
        public void TestGetByPatId1()
        {
            IEnumerable<VisitDto> visitList = queryHandler.GetByPatId(1);

            Assert.IsTrue(visitList.Count() == 1);
        }

        [TestMethod]
        public void TestGetByPatId2()
        {
            IEnumerable<VisitDto> visitList = queryHandler.GetByPatId(2);

            Assert.IsTrue(visitList.Count() == 0);
        }

        [TestMethod]
        public void TestGetByDateNPatientId1()
        {
            DateTime date = new DateTime(2022, 5, 29, 8, 0, 0);
            IEnumerable<VisitDto> visitList = queryHandler.GetByDateNPatientId(date, 1);

            Assert.IsTrue(visitList.Count() == 1);
        }

        [TestMethod]
        public void TestGetByDateNPatientId2()
        {
            DateTime date = new DateTime(1992, 5, 29, 8, 0, 0);
            IEnumerable<VisitDto> visitList = queryHandler.GetByDateNPatientId(date, 1);

            Assert.IsTrue(visitList.Count() == 0);
        }

        [TestMethod]
        public void TestGetByDateNPatientId3()
        {
            DateTime date = new DateTime(2022, 5, 29, 8, 0, 0);
            IEnumerable<VisitDto> visitList = queryHandler.GetByDateNPatientId(date, 2);

            Assert.IsTrue(visitList.Count() == 0);
        }

        [TestMethod]
        public void TestGetByDateNDoctorId1()
        {
            DateTime date = new DateTime(2022, 5, 29, 8, 0, 0);
            IEnumerable<VisitDto> visitList = queryHandler.GetByDateNDoctorId(date, 1);

            Assert.IsTrue(visitList.Count() == 1);
        }

        [TestMethod]
        public void TestGetByDateNDoctorId2()
        {
            DateTime date = new DateTime(1992, 5, 29, 8, 0, 0);
            IEnumerable<VisitDto> visitList = queryHandler.GetByDateNDoctorId(date, 1);

            Assert.IsTrue(visitList.Count() == 0);
        }

        [TestMethod]
        public void TestGetByDateNDoctorId3()
        {
            DateTime date = new DateTime(2022, 5, 29, 8, 0, 0);
            IEnumerable<VisitDto> visitList = queryHandler.GetByDateNDoctorId(date, 2);

            Assert.IsTrue(visitList.Count() == 0);
        }

        [TestMethod]
        public void TestGetByClinicNDoctorId1()
        {
            IEnumerable<VisitDto> visitList = queryHandler.GetByClinicNDoctorId("Warszawska 1", 1);

            Assert.IsTrue(visitList.Count() == 1);
        }

        [TestMethod]
        public void TestGetByClinicNDoctorId2()
        {
            IEnumerable<VisitDto> visitList = queryHandler.GetByClinicNDoctorId("Noakowskiego 15", 1);

            Assert.IsTrue(visitList.Count() == 0);
        }

        [TestMethod]
        public void TestGetByClinicNDoctorId3()
        {
            IEnumerable<VisitDto> visitList = queryHandler.GetByClinicNDoctorId("Warszawska 1", 2);

            Assert.IsTrue(visitList.Count() == 0);
        }
    }
}
