using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            List<Movie> moviesList = new List<Movie>()
            {
                new Movie { Title = "מטריקס", Genre = "מדע בדיוני",
                            Year = 1999 },
                new Movie { Title = "מלך האריות", Genre = "אנימציה",
                            Year = 1994 },
                new Movie { Title = "התחלה", Genre = "מתח", Year =
                            2010 }
            };

            // 2. קישור רשימת האובייקטים ל-ListView
            MoviesListView.ItemsSource = null;
            MoviesListView.ItemsSource = moviesList;



        }


        private void MoviesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 1. הגנה: תמיד בודקים ש-SelectedItem אינו null.
            // (הוא עלול להיות null אם המערכת מבצעת איפוס או ניקוי של הרשימה)
            if (MoviesListView.SelectedItem != null)
            {
                // 2. המרת הפריט הנבחר (שהוא מטיפוס object כללי) חזרה למחלקה שלנו
                Movie selectedMovie = (Movie)MoviesListView.SelectedItem;

                // 3. שימוש בנתונים של הפריט שנבחר
                MessageBox.Show($"בחרת בסרט:{ selectedMovie.Title}\nז'אנר: { selectedMovie.Genre} ", 
                                "פרטי הסרט הנבחר", 
                            MessageBoxButton.OK, 
                            MessageBoxImage.Information);

             
            }
        }


    }
}
