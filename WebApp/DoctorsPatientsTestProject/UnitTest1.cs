using Doctors.Domain;
using Doctors.Domain.Aggregate;
using Doctors.Domain.Seed;
using Doctors.Infrastractures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorsPatientsTestProject
{
    [TestClass]
    public class UnitTest1
    {


        //Test metody GetAll oraz dodawania nowych doktorów
        [TestMethod]
        public void TestMethod1()
        {
            DoctorRepo doctorRepo = new DoctorRepo();
            List<Specialization> specialization = new();
            specialization.Add((Specialization)Enum.Parse(typeof(Specialization), "pediatra"));
            Doctor doc1 = new Doctor(40, "Ernest", "Hemingway", 1.88, specialization, Gender.Male);
            List<Doctor> doctors1 = (List<Doctor>)doctorRepo.GetAll();
            int size1 = doctors1.Count;
            doctorRepo.AddDoctor(doc1);
            List<Doctor> doctors2 = (List<Doctor>)doctorRepo.GetAll();
            int size2 = doctors2.Count;
            Assert.IsTrue(size1 + 1 == size2);
        }



        //Test metody GetAll oraz dodawania nowych pacjentów
        [TestMethod]
        public void TestMethod2()
        {
            PatientRepo patientRepo = new PatientRepo();
            Patient pat1 = new Patient(60, "Andrzej", "Kmicic", 1.88, "99010111110", Gender.Male);
            List<Patient> patients1 = (List<Patient>)patientRepo.GetAll();
            int size1 = patients1.Count;
            patientRepo.AddPatient(pat1);
            List<Patient> patients2 = (List<Patient>)patientRepo.GetAll();
            int size2 = patients2.Count;
            Assert.IsTrue(size1 + 1 == size2);
        }


        //Test metody GetById dla doktorów
        [TestMethod]
        public void TestMethod3()
        {
            DoctorRepo doctorRepo = new DoctorRepo();
            List<Specialization> specialization = new();
            specialization.Add((Specialization)Enum.Parse(typeof(Specialization), "pediatra"));
            int id = 8888;
            Doctor doc1 = new Doctor(id, "ZZZ", "YYY", 1.88, specialization, Gender.Male);
            doctorRepo.AddDoctor(doc1);
            IEnumerable<Doctor> doctors2 = doctorRepo.GetById(id);
            Assert.IsTrue(doctors2.ToList()[0].Id == id && doctors2.ToList()[0].Name == "ZZZ");
        }

        //Test metody GetById dla doktorów
        [TestMethod]
        public void TestMethod4()
        {
            DoctorRepo doctorRepo = new DoctorRepo();
            List<Specialization> specialization = new();
            specialization.Add((Specialization)Enum.Parse(typeof(Specialization), "pediatra"));
            int id = 9999;
            Doctor doc1 = new Doctor(id, "Test", "Test", 1.88, specialization, Gender.Male);
            doctorRepo.AddDoctor(doc1);
            IEnumerable<Doctor> doctors2 = doctorRepo.GetById(id);
            Assert.IsTrue(doctors2.Count()>0);
        }




        //Test metody GetById dla pacjentów
        [TestMethod]
        public void TestMethod5()
        {
            PatientRepo patientRepo = new PatientRepo();
            int id = 8888;
            Patient pat1 = new Patient(id, "WWW", "YYY", 1.88, "99010111111", Gender.Male);
            patientRepo.AddPatient(pat1);
            IEnumerable<Patient> patients2 = patientRepo.GetById(id);
            Assert.IsTrue(patients2.ToList()[0].Id == id && patients2.ToList()[0].Name == "WWW");
        }



        //Test metody GetById dla pacjentów
        [TestMethod]
        public void TestMethod6()
        {
            PatientRepo patientRepo = new PatientRepo();
            int id = 9999;
            Patient pat1 = new Patient(id, "Test", "Test", 1.88, "99010111111", Gender.Male);
            patientRepo.AddPatient(pat1);
            IEnumerable<Patient> patients2 = patientRepo.GetById(id);
            Assert.IsTrue(patients2.Count()>0);
        }


    }
}
