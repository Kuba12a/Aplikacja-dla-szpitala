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

  using ZsutPw.Patterns.WindowsApplication.Model;
  using ZsutPw.Patterns.WindowsApplication.Utilities;

  public partial class Controller : PropertyContainerBase, IController
  {
    public IModel Model { get; private set; }

    public Controller( IEventDispatcher dispatcher, IModel model ) : base( dispatcher )
    {
      this.Model = model;

      this.SearchPairsCommand = new ControllerCommand( this.SearchPairs );

      this.SearchPairsbyDateCommand = new ControllerCommand(this.SearchPairsbyDate);

      this.SearchPairsbyClinicCommand = new ControllerCommand(this.SearchPairsbyClinic);

      this.ShowListCommand = new ControllerCommand( this.ShowList );

      this.ShowMapCommand = new ControllerCommand(this.ShowMap);

      this.ShowFieldCommand = new ControllerCommand(this.ShowField);
    }
  }
}
