using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZsutPwPatterns.WindowsApplication.Logic.Model.Data
{
    public class DoctorDto
    {


        public DoctorDto() { }
        public DoctorDto(string name, List<int> specialization, double height, string gender)
        {
            this.Name = name;
            this.Specialization = specialization;
            this.Height = height;
            this.Gender = gender;
        }
        public string Name { get; set; }
        public List<int> Specialization { get; set; }
        public double Height { get; set; }

        public string Gender { get; set; }








    }
}
