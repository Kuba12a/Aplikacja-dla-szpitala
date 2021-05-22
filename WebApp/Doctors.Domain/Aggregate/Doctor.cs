using Doctors.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Doctors.Domain
{

    public enum Specialization
    {

        laryngolog,
        dermatolog,
        ortopeda,
        optyk,
        pediatra

    }
    public class Doctor : Person
    {
        


        
        public double Height { get; private set; }

        public List<Specialization> Specialization { get; set; }

        public Doctor(int id, string name, string surname, double height, List<Specialization> specialization, Gender gender) : base(id, name, surname, gender)
        {
            Debug.Assert(condition: height > 0);
            
            this.Height = height;
            this.Specialization = specialization;
        }
      
        }
}
