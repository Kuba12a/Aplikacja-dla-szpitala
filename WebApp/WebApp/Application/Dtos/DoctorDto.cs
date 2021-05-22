using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Application
{
    public class DoctorDto
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public List<string> Specialization { get;  set; }
        public double Height { get;  set; }

        public string Gender { get; set; }


    }
}
