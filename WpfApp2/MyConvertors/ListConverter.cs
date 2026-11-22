
    using System;
    using System.Globalization;
    using System.Windows.Data;
    using System.Windows.Media;

    namespace WpfApp2.MyConvertors
    {
        // 1. ממיר לפורמט תאריך (אירופאי: dd/MM/yyyy | אמריקאי: MM/dd/yyyy)
        public class DateFormatConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is DateTime date)
                {
                    string formatType = parameter as string;
                    if (formatType == "US")
                    {
                        return date.ToString("MM/dd/yyyy");
                    }
                    // ברירת מחדל: פורמט אירופאי / ישראלי
                    return date.ToString("dd/MM/yyyy");
                }
                return string.Empty;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }

        // 2. ממיר לחישוב ימים שנותרו עד לתפוגה
        public class DaysRemainingConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is DateTime expirationDate)
                {
                    // חישוב ההפרש בימים שלמים מהיום (DateTime.Today)
                    int daysLeft = (expirationDate.Date - DateTime.Today).Days;

                    // אם התאריך עבר, נחזיר 0
                    return daysLeft > 0 ? daysLeft : 0;
                }
                return 0;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }

        // 3. ממיר לצביעת השורה כולה באדום אם פג התוקף
        public class ExpiredToRowColorConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is DateTime expirationDate)
                {
                    // אם תאריך התפוגה קטן או שווה להיום (0 ימים נותרו)
                    if (expirationDate.Date <= DateTime.Today)
                    {
                        // אדום עדין (LightCoral) כדי שהטקסט השחור יישאר קריא
                        return Brushes.LightCoral;
                    }
                }
                return Brushes.Transparent;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        
    }

}
