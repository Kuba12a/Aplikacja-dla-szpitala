using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.Dtos
{
    public class PatientDto
    {
        public PatientDto(int id, string name, string surname, double height, string pesel, string gender)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Height = height;
            this.Pesel = pesel;
            this.Gender = gender;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public double Height { get; set; }

        public string Pesel { get; set; }
        public string Gender { get; set; }
    }
}
