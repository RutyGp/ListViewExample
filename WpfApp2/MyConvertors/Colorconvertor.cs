using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp2.MyConvertors
{
    public class BoolToColorConverter : IValueConverter
    {
        // מעבר מהקוד (bool) אל המסך (Color/Brush)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isUrgent && isUrgent)
            {
                return Brushes.Red; // אם המשימה דחופה - צבע אדום
            }
            return Brushes.Black; // ברירת מחדל - צבע שחור
        }

        // מעבר מהמסך חזרה לקוד (לא נחוץ בדוגמה זו)
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
