

namespace ZsutPw.Patterns.WindowsApplication.View
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using Windows.UI.Xaml.Data;

    using ZsutPw.Patterns.WindowsApplication.Model;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public class PairConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            PatientVisitPairDto pairData = (PatientVisitPairDto)value;

            String toReturn = String.Format("Doctor: {0} {1}   has visit at: {2} in {3}({4})" , pairData.Name, pairData.Surname, pairData.date, pairData.clinicName, pairData.adres);

          /*  foreach (string i in pairData.Specialization)
            {
                toReturn = toReturn + ", " + i;


            }
          */
            return toReturn;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
