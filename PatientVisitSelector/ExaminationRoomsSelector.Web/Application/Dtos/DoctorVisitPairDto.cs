using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Application;

namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    public class DoctorVisitPairDto
    {

        public DoctorVisitPairDto(DoctorDto doctor , VisitDto visit)
        {
            this.Name = doctor.Name;
            this.Surname = doctor.Surname;
            this.date = visit.date;
            this.Specialization = doctor.Specialization;
            this.DoctorId = doctor.Id;

        }
        public List<string> Specialization { get; set; }
        public string date { get; set; }
        public int DoctorId { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }


    }
}
