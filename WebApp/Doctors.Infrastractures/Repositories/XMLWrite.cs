using Doctors.Domain;
using Doctors.Domain.Aggregate;
using Doctors.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Doctors.Infrastractures.Repositories
{
    public static class XMLWrite
    {
        

        public static List<Doctor> ReadDoctorsFromXML()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");


            XmlDocument xdc = new XmlDocument();
            try
            {
                xdc.Load(@"DoctorsRepo.xml");
            }
            catch (XmlException) { }

            List<Doctor> DoctorsList = new List<Doctor>();

            foreach (XmlElement element in xdc.GetElementsByTagName("Doctor"))
            {
                List<Specialization> specializations = new();

              
               
                XmlNodeList nodeList = element.ChildNodes;

                int id = Int32.Parse(nodeList.Item(0).InnerText);

                string name = nodeList.Item(1).InnerText;

                string surname = nodeList.Item(2).InnerText;

                string height = nodeList.Item(3).InnerText;

                string gender = nodeList.Item(4).InnerText;



                foreach (XmlElement element2 in element.GetElementsByTagName("Specialization"))
                {
                    if (element2.ChildNodes.Item(0).InnerText == null)
                    {
                        specializations = null;
                    }
                    else
                    {
                        specializations.Add((Specialization)Enum.Parse(typeof(Specialization), element2.InnerText));
                    }


                }
                
                    Doctor doct = new Doctor(id, name, surname, Double.Parse(height), specializations, (Gender)Enum.Parse(typeof(Gender), gender));
                    DoctorsList.Add(doct);
                


            }

            return DoctorsList;
        }


        public static List<Patient> ReadPatientsFromXML()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");


            XmlDocument xdc = new XmlDocument();
            try
            {
                xdc.Load(@"PatientsRepo.xml");
            }
            catch (XmlException) { }

            List<Patient> PatientsList = new List<Patient>();

            foreach (XmlElement element in xdc.GetElementsByTagName("Patient"))
            {
                



                XmlNodeList nodeList = element.ChildNodes;

                int id = Int32.Parse(nodeList.Item(0).InnerText);

                string name = nodeList.Item(1).InnerText;

                string surname = nodeList.Item(2).InnerText;

                string height = nodeList.Item(3).InnerText;

                string pesel = nodeList.Item(4).InnerText;

                string gender = nodeList.Item(5).InnerText;



               

                Patient patient = new Patient(id, name, surname, Double.Parse(height), pesel, (Gender)Enum.Parse(typeof(Gender), gender));
                PatientsList.Add(patient);



            }

            return PatientsList;
        }


        public static void WriteDoctorToXML(Doctor doctor, string path)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(path);
            }
            catch (XmlException) { }

            XmlElement xmlElement = doc.CreateElement("Doctor");
            
            XmlElement e1 = xmlElement;
            
            doc.DocumentElement.AppendChild(e1);
            e1.AppendChild(doc.CreateElement("Id")).InnerText = doctor.Id.ToString();
            e1.AppendChild(doc.CreateElement("Name")).InnerText = doctor.Name.ToString();
            e1.AppendChild(doc.CreateElement("Surname")).InnerText = doctor.Surname.ToString();
            e1.AppendChild(doc.CreateElement("Height")).InnerText = doctor.Height.ToString();
            e1.AppendChild(doc.CreateElement("Gender")).InnerText = doctor.Gender.ToString();

            if (doctor.Specialization != null)
            {
                XmlElement xmlElement2 = doc.CreateElement("Specializations");

                foreach (Specialization i in doctor.Specialization)
                {

                    xmlElement2.AppendChild(doc.CreateElement("Specialization")).InnerText = i.ToString();

                }
                e1.AppendChild(xmlElement2);
            }
            doc.Save(path);

           



        }

        public static void WritePatientToXML(Patient patient, string path)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(path);
            }
            catch (XmlException) { }

            XmlElement xmlElement = doc.CreateElement("Patient");

            XmlElement e1 = xmlElement;

            doc.DocumentElement.AppendChild(e1);
            e1.AppendChild(doc.CreateElement("Id")).InnerText = patient.Id.ToString();
            e1.AppendChild(doc.CreateElement("Name")).InnerText = patient.Name.ToString();
            e1.AppendChild(doc.CreateElement("Surname")).InnerText = patient.Surname.ToString();
            e1.AppendChild(doc.CreateElement("Height")).InnerText = patient.Height.ToString();
            e1.AppendChild(doc.CreateElement("Pesel")).InnerText = patient.Pesel;
            e1.AppendChild(doc.CreateElement("Gender")).InnerText = patient.Gender.ToString();

            
            doc.Save(path);





        }
    }
}