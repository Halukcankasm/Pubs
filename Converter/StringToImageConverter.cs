using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Pubs.Converter
{
    public class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((String)value)
            {
                case "business":
                    return "/Source/BookTypeIcons/businessBookIcon.png";
                case "mod_cook":
                    return "/Source/BookTypeIcons/cookBookIcon.png";
                case "UNDECIDED":
                    return "/Source/BookTypeIcons/undecidedBookIcon.png";
                case "Hepsi":
                    return "/Source/BookTypeIcons/undecidedBookIcon.png";
                case "popular_comp":
                    return "/Source/BookTypeIcons/popularBookIcon.png";
                case "psychology":
                    return "/Source/BookTypeIcons/psychologyBookIcon.png";
                case "trad_cook":
                    return "/Source/BookTypeIcons/cookBookIcon.png";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
