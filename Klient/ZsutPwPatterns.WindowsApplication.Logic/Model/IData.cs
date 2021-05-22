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

  using System.ComponentModel;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public interface IData : INotifyPropertyChanged
  {
    string SearchText { get; set; }

    string SearchText2 { get; set; }

    string SearchText3 { get; set; }

    List<PatientVisitPairDto> PairList { get; }

    PatientVisitPairDto SelectedPair { get; set; }
  }
}
