﻿using System;
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
                    return "/Source/Images/BookTypeIcons/businessBookIcon.png";
                case "mod_cook":
                    return "/Source/Images/BookTypeIcons/cookBookIcon.png";
                case "UNDECIDED":
                    return "/Source/Images/BookTypeIcons/undecidedBookIcon.png";
                case "Hepsi":
                    return "/Source/Images/BookTypeIcons/undecidedBookIcon.png";
                case "popular_comp":
                    return "/Source/Images/BookTypeIcons/popularBookIcon.png";
                case "psychology":
                    return "/Source/Images/BookTypeIcons/psychologyBookIcon.png";
                case "trad_cook":
                    return "/Source/Images/BookTypeIcons/cookBookIcon.png";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
