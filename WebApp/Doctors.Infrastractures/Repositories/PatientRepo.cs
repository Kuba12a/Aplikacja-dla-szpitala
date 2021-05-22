using System;
using System.Collections.Generic;
using System.Linq;
using Doctors.Domain;
using Doctors.Domain.Aggregate;
using Doctors.Domain.Seed;
using Doctors.Infrastractures.Repositories;

namespace Doctors.Infrastractures
{
    public class PatientRepo : IPatientRepository
    {
        const string Path = "PatientsRepo.xml";

        public IEnumerable<Patient> GetAll()
        {
            return XMLWrite.ReadPatientsFromXML();
        }

        public IEnumerable<Patient> GetById(int id)
        {
            return XMLWrite.ReadPatientsFromXML()?.Where(ld => ld.Id == id);
        }

        public void AddPatient(Patient patient)
        {
            XMLWrite.WritePatientToXML(patient, Path);
        }
    }
}
