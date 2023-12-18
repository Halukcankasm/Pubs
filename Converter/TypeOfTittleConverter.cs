using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Pubs.Converter
{
    public class TypeOfTittleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((String)value)
            {
                case "business":
                    return "Business";
                case "mod_cook":
                    return "Modern Cook";
                case "UNDECIDED":
                    return "Undecided";
                case "popular_comp":
                    return "Pupular Composition";
                case "psychology":
                    return "Psychology";
                case "trad_cook":
                    return "Trad Cook";
                case null:
                    return "Hepsi";
            }
            return value.ToString(); ;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
