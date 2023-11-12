using System.Security.Cryptography.X509Certificates;

namespace CarsAndUsedCarsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.Cars.Add(new Car    ("Nikolai", "Model S  ", 2017, 54999.9));
            Car.Cars.Add(new Car    ("Fourd  ", "Escapade ", 2017, 31999.9));
            Car.Cars.Add(new Car    ("Chewie ", "Vette    ", 2017, 44989.95));
            Car.Cars.Add(new UsedCar("Hyonda ", "Prior    ", 2015, 14795.5, 35987.6));
            Car.Cars.Add(new UsedCar("GC     ", "Chirpus  ", 2013, 8500, 12345));
            Car.Cars.Add(new UsedCar("GC     ", "Witherell", 2016, 14450, 3500.3));

            Car.NewCars.Add(new Car("Nikolai", "Model S  ", 2017, 54999.9));
            Car.NewCars.Add(new Car("Fourd  ", "Escapade ", 2017, 31999.9));
            Car.NewCars.Add(new Car("Chewie ", "Vette    ", 2017, 44989.95));
            Car.UsedCars.Add(new UsedCar("Hyonda ", "Prior    ", 2015, 14795.5, 35987.6));
            Car.UsedCars.Add(new UsedCar("GC     ", "Chirpus  ", 2013, 8500, 12345));
            Car.UsedCars.Add(new UsedCar("GC     ", "Witherell", 2016, 14450, 3500.3));

            Console.Write("Username: ");
            string UserName = Console.ReadLine();
            if (UserName.Trim().ToLower().StartsWith("admin"))
            {
                Menus.PrintAdminMenu(UserName);
            }
            else
            {
                Menus.PrintClientMenu(UserName);
            }


            //do
            //{
            //    Car.ListCars();
            //    int MenuNumber = 0;
            //    do
            //    {
            //        Console.Write("Which car would you like?  ");
            //        string MenuOption = Console.ReadLine();
            //        MenuNumber = Validator.validInteger(MenuOption);
            //    } while (MenuNumber < 1);
            //    Console.WriteLine(Car.Cars[MenuNumber - 1]);
            //    Console.WriteLine("Excellent! Our finance department will be in touch shortly.");
            //    Console.WriteLine("");
            //    Car.RemoveCars(MenuNumber - 1);
            //} while (Car.Cars.Count > 0);



            //List<Car> cars1 = Car.Cars.Where(l => l.CarMake.Trim() == "GC").ToList();


            Console.WriteLine("Have a great day!");
        }
    }
}