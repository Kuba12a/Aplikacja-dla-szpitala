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

  using System.Net.Http;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public class NetworkClient : INetwork
  {
    private readonly ServiceClient serviceClient;

    public NetworkClient( string serviceHost, int servicePort )
    {
      Debug.Assert( condition: !String.IsNullOrEmpty( serviceHost ) && servicePort > 0 );

      this.serviceClient = new ServiceClient( serviceHost, servicePort );
    }

   

        public IEnumerable<PatientVisitPairDto> GetPairs(string id) {
            string callUri = String.Format("Doctors-visits?doctorId={0}", id);

            IEnumerable<PatientVisitPairDto> pairs = this.serviceClient.CallWebService<IEnumerable<PatientVisitPairDto>>(HttpMethod.Get, callUri);

            return pairs;


        }

        public IEnumerable<PatientVisitPairDto> GetPairsbyDate(string id, string date)
        {
            string callUri = String.Format("Doctors-visitsByDate?date={0}&doctorId={1}", date, id);

            IEnumerable<PatientVisitPairDto> pairs = this.serviceClient.CallWebService<IEnumerable<PatientVisitPairDto>>(HttpMethod.Get, callUri);

            return pairs;


        }

        public IEnumerable<PatientVisitPairDto> GetPairsbyClinic(string id, string clinic)
        {
            string callUri = String.Format("Doctors-visitsByClinic?clinic={0}&doctorId={1}", clinic, id);

            IEnumerable<PatientVisitPairDto> pairs = this.serviceClient.CallWebService<IEnumerable<PatientVisitPairDto>>(HttpMethod.Get, callUri);

            return pairs;


        }
    }
}
