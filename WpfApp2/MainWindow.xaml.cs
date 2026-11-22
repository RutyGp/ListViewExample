using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> cities;
        public MainWindow()
        {
            InitializeComponent();

            Movie m1 = new Movie() { Title = "zzz", Genre = "xxx", Year = 2022 };










            cities = new List<string>()
            {
                "תל אביב",  "ירושלים",  "חיפה", "באר שבע"
            };

            // 2. קישור הרשימה ל-ListView במסך
            SimpleListView.ItemsSource = cities;

            int y = DateTime.Now.Year;
            List<int> yearList = new List<int>();
            for (int i = y-120; i <= y; i++)
            {
                yearList.Add(i);
            }
            years.ItemsSource = yearList;



        }

        private void AddCity(object sender, RoutedEventArgs e)
        {
            string city = newCity.Text;
            cities.Add(city);
            SimpleListView.ItemsSource = null;
            SimpleListView.ItemsSource = cities;

            newCity.Text = string.Empty;
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

        private void Next2(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
        }

        private void Next3(object sender, RoutedEventArgs e)
        {
            ValueconverterWindow w = new ValueconverterWindow();
            w.Show();
        }
    }
}
