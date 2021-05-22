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

    public partial class Model : IData
  {
    public string SearchText
    {
      get { return this.searchText; }
      set
      {
        this.searchText = value;

        this.RaisePropertyChanged( "SearchText" );
      }
    }

    public string SearchText2
    {
      get { return this.searchText2; }
      set
      {
        this.searchText2 = value;

        this.RaisePropertyChanged("SearchText2");
       }
     }

    public string SearchText3
    {
       get { return this.searchText3; }
       set
       {
         this.searchText3 = value;

         this.RaisePropertyChanged("SearchText3");
       }
    }
    private string searchText;

    private string searchText2;

    private string searchText3;

        public List<PatientVisitPairDto> PairList
    {
      get { return this.pairList; }
      private set
      {
        this.pairList = value;

        this.RaisePropertyChanged( "PairList" );
      }
    }
    private List<PatientVisitPairDto> pairList = new List<PatientVisitPairDto>( );

    public PatientVisitPairDto SelectedPair
    {
      get { return this.selectedPair; }
      set
      {
        this.selectedPair = value;

        this.RaisePropertyChanged( "SelectedPair" );
      }
    }
    private PatientVisitPairDto selectedPair;
  }
}
