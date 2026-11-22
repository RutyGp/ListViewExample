using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp2.MyConvertors
{
    public class PriceToCurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is double price)
            {
                // עיצוב לפי פורמט מטבע מקומי (C = Currency)
                // בקוד זה אנחנו כופים את הפורמט של ישראל (₪)
                return price.ToString("C", new
                             CultureInfo("he-IL"));
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
