using DoctorVisitsSelector.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.Algorithm
{
    public class Algo
    {
        public Algo() { }


        public IEnumerable<PatientVisitPairDto> DoAlgorythmAsync(IEnumerable<PatientDto> patients, IEnumerable<VisitDto> visits)
        {

            if (patients is null || visits is null)
            {
                throw new NullReferenceException();
            }

            List<PatientVisitPairDto> pairs = new List<PatientVisitPairDto>();

            foreach (var item in visits)
            {
                foreach (var item2 in patients)
                {
                    if (item.PatientId == item2.Id)
                    {
                        PatientVisitPairDto pair = new PatientVisitPairDto(item2, item);
                        pairs.Add(pair);
                    }
                }
            }
            return pairs;
        }
    }
}
