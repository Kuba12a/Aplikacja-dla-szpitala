using ExaminationRoomsSelector.Web.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Application;

namespace ExaminationRoomsSelector.Web.Application.Algorithm
{
    public class Algorithm
    {
        public Algorithm() { }



        public IEnumerable<DoctorVisitPairDto> DoAlgorythmAsync(IEnumerable<DoctorDto> doctors, IEnumerable<VisitDto> visits)
        {
            
            if(doctors is null || visits is null)
            {
                throw new NullReferenceException();
            }

            List<DoctorVisitPairDto> pairs = new List<DoctorVisitPairDto>();

            foreach (var item in visits)
            {
                foreach(var item2 in doctors)
                {
                    if(item.DoctorId == item2.Id)
                    {
                        DoctorVisitPairDto pair = new DoctorVisitPairDto(item2, item);
                        pairs.Add(pair);
                    }
                }
            }
            return pairs;
            }

        
    }
}
