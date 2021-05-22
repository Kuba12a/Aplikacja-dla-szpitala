using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visits.Domain
{
    public class Clinic
    {
        public String Adress { get; set; }
        public String Name { get; set; }


        public Clinic(string adress, string name)
        {
            this.Adress = adress;
            this.Name = name;
        }

        public Clinic() { }

    }
}
