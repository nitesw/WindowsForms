using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_01
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public string Country { get; set; }

        public Product() :this("", 0, 0, 0, "") { }
        public Product(string n, int p, int q, int d, string c)
        {
            Name = n;
            Price = p;
            Quantity = q;
            Discount = d;
            Country = c;
        }

        public override string ToString()
        {
            return $"{Name}, {Price}$, quantity - {Quantity}, discount - {Discount}%, {Country}";
        }
    }
}
