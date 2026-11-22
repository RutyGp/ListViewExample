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
using WpfApp2.WpfApp;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for ValueconverterWindow.xaml
    /// </summary>
    public partial class ValueconverterWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        
            public ValueconverterWindow()
            {
                InitializeComponent();

                Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "חלב טרי",
                    Stock = 20,
                    ManufactureDate = DateTime.Today.AddDays(-2),
                    ExpirationDate = DateTime.Today.AddDays(5) // בתוקף (5 ימים)
                },
                new Product
                {
                    Name = "גבינה צהובה",
                    Stock = 8,
                    ManufactureDate = DateTime.Today.AddDays(-20),
                    ExpirationDate = DateTime.Today.AddDays(-1) // פג תוקף אתמול!
                },
                new Product
                {
                    Name = "לחם אחיד",
                    Stock = 12,
                    ManufactureDate = DateTime.Today,
                    ExpirationDate = DateTime.Today // פג תוקף היום (0 ימים)
                },
                new Product
                {
                    Name = "קופסת שימורים",
                    Stock = 50,
                    ManufactureDate = DateTime.Today.AddMonths(-6),
                    ExpirationDate = DateTime.Today.AddMonths(12) // בתוקף (הרבה זמן)
                }
            };

                this.DataContext = this;
            }
        }
    }

