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
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public partial class Model : IOperations
  {
    public void LoadPairList( )
    {
      /* AT
      this.LoadNodesTask( );
      */
      Task.Run( ( ) => this.LoadPairTask( ) );
    }

        public void LoadPairListbyDate()
        {
            /* AT
            this.LoadNodesTask( );
            */
            Task.Run(() => this.LoadPairbyDateTask());
        }

        public void LoadPairListbyClinic()
        {
            /* AT
            this.LoadNodesTask( );
            */
            Task.Run(() => this.LoadPairbyClinicTask());
        }

        private void LoadPairTask( )
    {
      INetwork networkClient = NetworkClientFactory.GetNetworkClient( );

      try
      {
               List<PatientVisitPairDto> pairs = (List<PatientVisitPairDto>)networkClient.GetPairs( this.SearchText );

                this.PairList = pairs;
      }
      catch( Exception )
      {
                
      }
    }

        private void LoadPairbyDateTask()
        {
            INetwork networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                List<PatientVisitPairDto> pairs = (List<PatientVisitPairDto>)networkClient.GetPairsbyDate(this.SearchText, this.SearchText2);

                this.PairList = pairs;
            }
            catch (Exception )
            {
                
            }
        }

        private void LoadPairbyClinicTask()
        {
            INetwork networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                List<PatientVisitPairDto> pairs = (List<PatientVisitPairDto>)networkClient.GetPairsbyClinic(this.SearchText, this.SearchText3);

                this.PairList = pairs;
            }
            catch (Exception )
            {
                
            }
        }
    }
}
