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

namespace ZsutPw.Patterns.WindowsApplication.Controller
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;
  using System.Threading.Tasks;

  using System.Windows.Input;

  public partial class Controller : IController
  {
    public ApplicationState CurrentState
    {
      get { return this.currentState; }
      set
      {
        this.currentState = value;

        this.RaisePropertyChanged( "CurrentState" );
      }
    }
    private ApplicationState currentState = ApplicationState.List;

    public ICommand SearchPairsCommand { get; private set; }

    public ICommand ShowListCommand { get; private set; }

    public ICommand ShowMapCommand { get; private set; }

    public ICommand ShowFieldCommand { get; private set; }

    public ICommand SearchPairsbyDateCommand { get; private set; }

    public ICommand SearchPairsbyClinicCommand { get; private set; }


        private void SearchPairs( )
    {
      this.Model.LoadPairList( );
    }

    private void SearchPairsbyDate( )
    {
      this.Model.LoadPairListbyDate( );
     }

    private void SearchPairsbyClinic( )
     {
            this.Model.LoadPairListbyClinic( );
     }

        private void ShowList( )
    {
      switch( this.CurrentState )
      {
        case ApplicationState.List:
          break;

        default:
          this.CurrentState = ApplicationState.List;
          break;
      }
    }

    private void ShowMap( )
    {
      switch( this.CurrentState )
      {
        case ApplicationState.Map:
          break;

        default:
          this.CurrentState = ApplicationState.Map;
          break;
      }
    }

    private void ShowField()
    {
       switch (this.CurrentState)
        {
          case ApplicationState.Field:
           break;

         default:
           this.CurrentState = ApplicationState.Field;
           break;
        }
     }
    }
}
