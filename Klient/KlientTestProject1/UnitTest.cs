
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class UnitTest1
    {
        INetwork networkClient = NetworkClientFactory.GetNetworkClient();

        //Test metody GetPairs(id)
        [TestMethod]
        public void TestMethod1()
        {
            string id = "1";
            IEnumerable<PatientVisitPairDto> pairs = networkClient.GetPairs(id);
            Assert.IsTrue(pairs.Count() > 0);

        }
    }
}




