using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    using System;

    namespace WpfApp
    {
        public class Product
        {
            public string Name { get; set; }
            public int Stock { get; set; }
            public DateTime ManufactureDate { get; set; }
            public DateTime ExpirationDate { get; set; }
        }
    }

}
