using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZsutPw.Patterns.WindowsApplication.Model;
using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;
namespace KlientTestProject
{
    [TestClass]
    public class UnitTest
    {
        FakeNetworkClient networkClient = new FakeNetworkClient();

        //Test metody GetPairs(id)
        [TestMethod]
        public void TestMethod1()
        {
            string id = "1";
            IEnumerable<PatientVisitPairDto> pairs = networkClient.GetPairs(id);
            Assert.IsTrue(pairs.Count() >= 0);

        }

        //Test metody GetPairsByClinic(id,clinic)
        [TestMethod]
        public void TestMethod2()
        {
            string id = "1";
            string clinic = "NFZ";
            IEnumerable<PatientVisitPairDto> pairs = networkClient.GetPairsbyClinic(id, clinic);
            Assert.IsTrue(pairs.ToList()[0].clinicName== clinic);

        }

        //Test metody GetPairsByDate(id, date)
        [TestMethod]
        public void TestMethod3()
        {
            string id = "1";
            string date = "01/01/1999";
            IEnumerable<PatientVisitPairDto> pairs = networkClient.GetPairsbyDate(id, date);
            Assert.IsTrue(pairs.ToList()[0].date == date);

        }


        //Test metody GetPairsByClinic(id,clinic)
        [TestMethod]
        public void TestMethod4()
        {
            string id = "1";
            string clinic = "NFZ";
            IEnumerable<PatientVisitPairDto> pairs = networkClient.GetPairsbyClinic(id, clinic);
            Assert.IsTrue(pairs.Count() ==1);

        }


        //Test metody GetPairsByDate(id, date)
        [TestMethod]
        public void TestMethod5()
        {
            string id = "1";
            string date = "01/01/1999";
            IEnumerable<PatientVisitPairDto> pairs = networkClient.GetPairsbyDate(id, date);
            Assert.IsTrue(pairs.Count()==1);

        }

        

    }
}


