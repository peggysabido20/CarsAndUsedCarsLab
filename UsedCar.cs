using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsLab
{
    public class UsedCar : Car
    {
        public UsedCar(string _carmake, string _carmodel, int _caryear, double _carprice, double _carmileage) : base(_carmake, _carmodel, _caryear, _carprice)
        {

            this.CarMileage = _carmileage;
        }
        public double CarMileage { get; set; }

        public override string ToString()
        {
            string ToStringOutput = base.ToString();
            ToStringOutput += $"\t(Used) {CarMileage:F2} miles";
            return ToStringOutput;
        }


    }
}
