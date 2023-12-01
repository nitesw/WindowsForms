using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04
{
    public class Order
    {
        private static int count = 1000;
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        public Order() :this(0) { }
        public Order(decimal price)
        {
            Number = count++;
            Date = DateTime.Now;
            TotalPrice = price;
        }

        public override string ToString()
        {
            return $"N {Number}    {Date.ToShortDateString()}    {TotalPrice}$";
        }
    }
}
