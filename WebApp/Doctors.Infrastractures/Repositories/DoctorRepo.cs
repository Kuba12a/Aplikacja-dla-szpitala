using System;
using System.Collections.Generic;
using System.Linq;
using Doctors.Domain;
using Doctors.Domain.Aggregate;
using Doctors.Domain.Seed;
using Doctors.Infrastractures.Repositories;

namespace Doctors.Infrastractures
{
    public class DoctorRepo : IDoctorRepository
    {
        const string Path = "DoctorsRepo.xml";

        public IEnumerable<Doctor> GetAll()
        {
            return XMLWrite.ReadDoctorsFromXML();
        }

        public IEnumerable<Doctor> GetById(int id)
        {
            return XMLWrite.ReadDoctorsFromXML()?.Where(ld => ld.Id==id);
        }

        public void AddDoctor(Doctor doctor)
        {
            XMLWrite.WriteDoctorToXML(doctor, Path);
        }
    }
}
