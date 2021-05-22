using Doctors.Domain;
using Doctors.Domain.Aggregate;
using Doctors.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Application.Dtos;

namespace WebApp.Application.Mapper
{
    public static class Mapper
    {
        public static DoctorDto Map(this Doctor doctor)
        {
            if (doctor == null)
                return null;

            return new DoctorDto
            {
                Id = doctor.Id,

                Name = doctor.Name,

                Surname = doctor.Surname,

                Specialization = doctor.Specialization.ConvertAll(s => s.ToString()),

                Height = doctor.Height,

                Gender = doctor.Gender.ToString()


            };
        }
        public static Doctor Map(this DoctorDto doctor)
        {
            if (doctor == null)
                return null;

           
                return new Doctor(doctor.Id, doctor.Name, doctor.Surname, Convert.ToDouble(doctor.Height), doctor.Specialization.ConvertAll(s => (Specialization)Enum.Parse(typeof(Specialization), s)), (Gender)Enum.Parse(typeof(Gender), doctor.Gender) );
            
           
            
            
        }


        public static PatientDto Map(this Patient patient)
        {
            if (patient == null)
                return null;

            return new PatientDto
            {
                Id = patient.Id,

                Name = patient.Name,

                Surname = patient.Surname,

                Height = patient.Height,

                Gender = patient.Gender.ToString(),

                Pesel = patient.Pesel


            };
        }

        public static Patient Map(this PatientDto patient)
        {
            if (patient == null)
                return null;


            return new Patient(patient.Id, patient.Name, patient.Surname, Convert.ToDouble(patient.Height), patient.Pesel, (Gender)Enum.Parse(typeof(Gender), patient.Gender));




        }
    }
}
