
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Visits.Domain;

namespace Visits.Infrastructures
{
    public static class XMLRead
    {
        

        public static List<Visit> ReadVisitsFromXML()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");


            XmlDocument xdc = new XmlDocument();
            try
            {
                xdc.Load("../Visits.Infrastructures/Repositories/VisitsRepo.xml");
            }
            catch (XmlException) { }

            List<Visit> VisitsList = new List<Visit>();

            foreach (XmlElement element in xdc.GetElementsByTagName("Visit"))
            {

                Clinic clinic = new Clinic();

                XmlNodeList nodeList = element.ChildNodes;

                int id = Int32.Parse(nodeList.Item(0).InnerText);

                int docId = Int32.Parse(nodeList.Item(1).InnerText);

                int patId = Int32.Parse(nodeList.Item(2).InnerText);

                DateTime date = DateTime.Parse(nodeList.Item(3).InnerText);


                foreach (XmlElement element2 in element.GetElementsByTagName("Clinic"))
                {
                    if (element2.ChildNodes.Item(0).InnerText == null)
                    {
                         clinic = null;
                    }
                    else
                    {
                        clinic = new Clinic(element2.ChildNodes.Item(0).InnerText,
                        element2.ChildNodes.Item(1).InnerText);

                    }


                }
                
                    Visit visit = new Visit(id, docId, patId, date, clinic);
                    VisitsList.Add(visit);
                


            }

            return VisitsList;
        }

    }
}