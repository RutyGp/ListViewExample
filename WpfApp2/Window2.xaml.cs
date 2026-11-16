using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        public List<Movie> Movies { get; set; }

        public Window2()
        {
            InitializeComponent();

            // אתחול הרשימה עם נתונים לדוגמה
            Movies = new List<Movie>
            {
                new Movie { Title = "התחלה", Genre = "מדע בדיוני", Year = 2010 },
                new Movie { Title = "האביר האפל", Genre = "אקשן", Year = 2008 },
                new Movie { Title = "גוליית החלש", Genre = "אקשן", Year = 2008 },
                new Movie { Title = "מהודו ועד כוש", Genre = "אקשן", Year = 2018 },
                new Movie { Title = "הליצן", Genre = "דרמה", Year = 2024 }
            };

            // חיבור הרשימה ל-ListView
            MoviesListView.ItemsSource = Movies;
        }
        private void DeleteCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // המרת השולח ל-CheckBox
            if (sender is CheckBox checkBox)
            {
                // שליפת אובייקט הסרט המשויך לאותה שורה
                if (checkBox.DataContext is Movie movieToDelete)
                {
                    // הסרת הסרט מהאוסף (תעדכן אוטומטית את ה-ListView)
                    Movies.Remove(movieToDelete);
                    MoviesListView.ItemsSource = null; 
                    MoviesListView.ItemsSource = Movies;
                }
            }
        }
       
    }
    }
