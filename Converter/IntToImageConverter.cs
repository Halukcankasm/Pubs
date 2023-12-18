using Pubs.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Pubs.Converter
{
    public class IntToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((String)value)
            {
                //case BookTypeCategory.Business:
                //    return "/Source/BookTypeIcons/businessBookIcon.png";
                //case Enums.ModernCook:
                //    return "/Source/BookTypeIcons/cookBookIcon.png";
                //case Enums.Undecided:
                //    return "/Source/BookTypeIcons/undecidedBookIcon.png";
                //case Enums.Popular:
                //    return "/Source/BookTypeIcons/popularBookIcon.png";
                //case Enums.Psychology:
                //    return "/Source/BookTypeIcons/psychologyBookIcon.png";
                //case Enums.Tradcook:
                //    return "/Source/BookTypeIcons/cookBookIcon.png";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }



}
