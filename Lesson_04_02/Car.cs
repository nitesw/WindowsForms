using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_02
{
    [Serializable]
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int MileAge { get; set; }
        public decimal Volume { get; set; }

        public Car() :this("", 0, 0, 0) {}
        public Car(string model, int year, int mileage, decimal volume)
        {
            Model = model;
            Year = year;
            MileAge = mileage;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Year: {Year}, Mileage: {MileAge}, Volume: {Volume}";
        }
    }
}
