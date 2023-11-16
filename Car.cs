using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsLab
{
    public class Car
    {
        public Car()
        {
            CarMake = "";
            CarModel = "";
            CarYear = 0;
            CarPrice = 0;
        }

        public Car(string _carmake, string _carmodel, int _caryear, double _carprice)
        {
            CarMake = _carmake;
            CarModel = _carmodel;
            CarYear = _caryear;
            CarPrice = _carprice;
        }

        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public double CarPrice { get; set; }

        public static List<Car> Cars = new List<Car>();

        public override string ToString()
        {
            string ToStringOutput = $"{CarMake}\t" +
                                    $"{CarModel}\t" +
                                    $"{CarYear}\t" +
                                    $"{CarPrice:F2}\t";
            return ToStringOutput;
        }

        public static void ListCars()
        {
            for(int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. " + Cars[i]);
            }
        }

        public static void RemoveCars(int CarIdx)
        {
            Cars.RemoveAt(CarIdx);
        }
    }
}
