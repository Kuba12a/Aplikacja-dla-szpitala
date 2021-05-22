using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.Dtos
{
    public class ClinicDto
    {
        public ClinicDto(String adress, string name) 
        {
            this.Adress = adress;
            this.Name = name;
        }
        public String Adress { get; set; }
        public String Name { get; set; }
    }
}
