using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Order
    {
        public User User { get; set; }
        public List<Product> Products { get; set; }
        public List<int> Numbers { get; set; }
        public double TotalCost { get; set; }
        public string Status { get; set; } = "...";
    }
}
