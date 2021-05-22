using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZsutPwPatterns.WindowsApplication.Logic.Model.Data
{
    public class DoctorExaminationRoomPairDto
    {

        public DoctorExaminationRoomPairDto() { }
        public DoctorExaminationRoomPairDto(string Name, List<int> Specialization, string Number)
        {
            this.Name = Name;
            this.Specialization = Specialization;
            this.Number = Number;

        }

        public DoctorExaminationRoomPairDto(DoctorDto doctor, ExaminationRoomDto examinationRoom)
        {
            this.Name = doctor.Name;
            this.Specialization = doctor.Specialization;
            this.Number = examinationRoom.Number;

        }

        public string Name { get; set; }
        public List<int> Specialization { get; set; }

        public string Number { get; set; }




    }
}
