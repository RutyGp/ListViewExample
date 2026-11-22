using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace WpfApp2.MyConvertors
{
    public class StockToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string text && int.TryParse(text, out int stock))
            {
                // אם המלאי הוא 0 - נרצה להציג (Visible) את התראת האזהרה
                
                if (stock == 0)
                {
                    return Visibility.Visible;
                }
            }
            // בכל מצב אחר (יש מלאי) - נעלים את ההתראה לחלוטין מהמסך
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
