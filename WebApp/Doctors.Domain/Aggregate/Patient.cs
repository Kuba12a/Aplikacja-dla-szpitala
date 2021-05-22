using Doctors.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors.Domain.Aggregate
{
    public class Patient : Person
    {




        public double Height { get; private set; }

        public string Pesel { get; private set; }


        public Patient(int id, string name, string surname, double height, string pesel, Gender gender) : base(id, name, surname, gender)
        {
            Debug.Assert(condition: height > 0);
            Debug.Assert(condition: pesel.Length == 11);
            this.Pesel = pesel;

            this.Height = height;         
        }

    }
}
