//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace ZsutPw.Patterns.WindowsApplication.Model
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;
  using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public class FakeNetworkClient : INetwork
  {
    

     
        public IEnumerable<PatientVisitPairDto> GetPairsbyDate(string id, string date) {
            PatientVisitPairDto pair = new PatientVisitPairDto("Mariusz", "Mariuszowski", date, "Mickiewicza 4", "NFZ");
            PatientVisitPairDto pairTest = new PatientVisitPairDto("zz", "cc", "01/01/1111", "dd", "ww");
            List<PatientVisitPairDto> pairs = new List<PatientVisitPairDto>();
            pairs.Add(pair);
            pairs.Add(pairTest);
            List<PatientVisitPairDto> goodPairs = new List<PatientVisitPairDto>();
            foreach (var item in pairs)
            {
                if (item.date == date)
                {
                    goodPairs.Add(item);
                }
            }


            return goodPairs;

        }

        
        
        
        public IEnumerable<PatientVisitPairDto> GetPairsbyClinic(string id, string clinic) {
            PatientVisitPairDto pair = new PatientVisitPairDto("Mariusz", "Mariuszowski", "01/01/2021", "Mickiewicza 4", clinic);
            PatientVisitPairDto pairTest = new PatientVisitPairDto("zz", "cc", "01/01/1111", "dd", "ww");
            List<PatientVisitPairDto> pairs = new List<PatientVisitPairDto>();
            pairs.Add(pair);
            pairs.Add(pairTest);
            List<PatientVisitPairDto> goodPairs = new List<PatientVisitPairDto>();
            foreach(var item in pairs)
            {
                if( item.clinicName == clinic)
                {
                    goodPairs.Add(item);
                }
            }
            
            
            return goodPairs;
            
        }
        
        
        
        
        public IEnumerable<PatientVisitPairDto> GetPairs( string searchText) {

            PatientVisitPairDto pair = new PatientVisitPairDto("Mariusz", "Mariuszowski", "01/01/2021", "Mickiewicza 4", "Przychodnia NFZ");
            List<PatientVisitPairDto> pairs = new List<PatientVisitPairDto>();
            pairs.Add(pair);
            return pairs;
        }
  }
}
