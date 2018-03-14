using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Controls;
using System.Windows;

namespace XamlReview
{
    public class RoundingOffConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int inputValue;
            int.TryParse(value.ToString(), out inputValue);

            if (inputValue >= 0) return inputValue.ToString();
            else return string.Format("{0} *", 0);
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }

    public class BoolToStyleConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType == typeof(Style) && value is bool)
            {
                if ((bool)value)
                {
                    return FetchStyle("StyleOne");
                }
                else
                {
                    return FetchStyle("StyleTwo");
                }
            }
            return value;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }

        private Style FetchStyle(string styleName)
        {
            return Application.Current.Resources[styleName] as Style;
        }
    }
}
