using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZsutPwPatterns.WindowsApplication.Logic.Model.Data
{


        public class PatientVisitPairDto
        {
        public PatientVisitPairDto(string name, string surname, string date, string adres , string clinicName)
        {
            this.Name = name;
            this.Surname = surname;
            this.date = date;
            this.adres = adres;
            this.clinicName = clinicName;
        }
            public PatientVisitPairDto()
            {

            }
            public string date { get; set; }
            public string Name { get; set; }

            public string Surname { get; set; }

            public string adres { get; set; }
            public string clinicName { get; set; }


        
    }
}
