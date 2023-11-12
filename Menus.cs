using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsLab
{
    public class Menus
    {
        public static void PrintAdminMenu(string userInfo)
        {
            int MenuNumber = 0;
            while (MenuNumber < 5)
            {
                Console.Clear();
                Console.WriteLine($"Username: {userInfo}");
                Console.WriteLine("What would you like to do?\n[1]See car inventory\n[2]Add a car\n[3]Change a car\n[4]Remove a car\n[5]Exit");
                Console.WriteLine("");                
                do
                {
                    Console.Write("Select an option: ");
                    string MenuOption = Console.ReadLine();
                    MenuNumber = Validator.validInteger(MenuOption);
                } while (MenuNumber < 1 || MenuNumber > 5);
                switch (MenuNumber)
                {
                    case 1:
                        PrintSearchMenu();
                        break;
                    case 2:
                        PrintAddMenu();
                        break;
                    case 3:
                        ChangeCar();
                        break; 
                    case 4:
                        RemoveCar();
                        break; 
                }
            }            
        }

        public static void PrintClientMenu(string userInfo)
        {
            int MenuNumber = 0;
            while (MenuNumber < 3)
            {
                Console.Clear();
                Console.WriteLine($"Username: {userInfo}");
                Console.WriteLine("What would you like to do?\n[1]Purchase a car\n[2]Sell a car\n[3]Exit");
                Console.WriteLine("");
                do
                {
                    Console.Write("Select an option: ");
                    string MenuOption = Console.ReadLine();
                    MenuNumber = Validator.validInteger(MenuOption);
                } while (MenuNumber < 1 || MenuNumber > 3);
                switch (MenuNumber)
                {
                    case 1:
                        PurchaseCar();
                        break;
                    case 2:
                        PrintAddMenu();
                        break;
                }
            }            
        }

        public static void PrintSearchMenu()
        {
            Console.WriteLine("Search by:\n[1]Make\n[2]Model\n[3]Year\n[4]Price\n[5]New cars\n[6]Used cars\n[7]See all\n[8]Return to previous menu");
            Console.WriteLine("");
            int MenuNumber = 0;
            int inputCarYear = 0;
            double inputCarPrice = 0;
            do
            {
                Console.Write("Select an option: ");
                string MenuOption = Console.ReadLine();
                MenuNumber = Validator.validInteger(MenuOption);
            } while (MenuNumber < 1 || MenuNumber > 8);
            switch (MenuNumber)
            {
                case 1:
                    Console.Write("What is the make name? ");
                    string inputMake = Console.ReadLine().Trim().ToLower();
                    List<Car> cars1 = Car.Cars.Where(l => l.CarMake.Trim().ToLower() == inputMake).ToList();
                    foreach (Car car in cars1)
                    {
                        Console.WriteLine(car);
                    }
                    break;
                case 2:
                    Console.Write("What is the model? ");
                    string inputModel = Console.ReadLine().Trim().ToLower();
                    List<Car> cars2 = Car.Cars.Where(l => l.CarModel.Trim().ToLower() == inputModel).ToList();
                    foreach (Car car in cars2)
                    { 
                        Console.WriteLine(car); 
                    }
                    break;
                case 3:
                    do
                    {
                        Console.Write("What is the year? ");
                        string inputYear = Console.ReadLine();
                        inputCarYear = Validator.validInteger(inputYear);
                    } while (inputCarYear == 0);                    
                    List<Car> cars3 = Car.Cars.Where(l => l.CarYear == inputCarYear).ToList();
                    foreach (Car car in cars3)
                    {
                        Console.WriteLine(car);
                    }
                    break;
                case 4:
                    do
                    {
                        Console.Write("What is the price? ");
                        string inputPrice = Console.ReadLine();
                        inputCarPrice = Validator.validDouble(inputPrice);
                    } while (inputCarPrice == 0);
                    List<Car> cars4 = Car.Cars.Where(l => l.CarPrice <= inputCarPrice).ToList();
                    foreach (Car car in cars4)
                    {
                        Console.WriteLine(car);
                    }
                    break;
                case 5:
                    foreach (Car car in Car.NewCars)
                    {
                        Console.WriteLine(car);
                    }
                    break;
                case 6:
                    foreach (Car car in Car.UsedCars)
                    {
                        Console.WriteLine(car);
                    }
                    break;
                case 7:
                    Car.ListCars();
                    break;
            }
            Console.Write("Press any key to continue ...");
            Console.ReadKey();
        }

        public static void PrintAddMenu()
        {
            Console.WriteLine("Add Menu:\n[1]New car\n[2]Used car\n[3]Return to previous menu");
            Console.WriteLine("");
            int MenuNumber = 0;
            do
            {
                Console.Write("Select an option: ");
                string MenuOption = Console.ReadLine();
                MenuNumber = Validator.validInteger(MenuOption);
            } while (MenuNumber < 1 || MenuNumber > 3); 

            switch (MenuNumber)
            {
                case 1:
                    AddCar();
                    break;
                case 2:
                    AddUsedCar();
                    break;
            }
        }

        private static void AddCar()
        {
            string inputCarMake = "";
            string inputCarModel = "";
            int inputCarYear = 0;
            double inputCarPrice = 0;
            do
            {
                Console.Write("Enter make: ");
                inputCarMake = Console.ReadLine();
            } while (inputCarMake == "");
            do
            {
                Console.Write("Enter model: ");
                inputCarModel = Console.ReadLine();
            } while (inputCarModel == "");
            do
            {
                Console.Write("Enter year: ");
                string inputYear = Console.ReadLine();
                inputCarYear = Validator.validInteger(inputYear);
            } while (inputCarYear == 0);
            do
            {
                Console.Write("Enter price: ");
                string inputPrice = Console.ReadLine();
                inputCarPrice = Validator.validDouble(inputPrice);
            } while (inputCarPrice == 0);
            if (Validator.YesNoValue("Do you want to add this car ") == "y")
            {
                Car.Cars.Add(new Car(inputCarMake, inputCarModel, inputCarYear, inputCarPrice));
            }            
        }

        private static void AddUsedCar()
        {
            string inputCarMake = "";
            string inputCarModel = "";
            int inputCarYear = 0;
            double inputCarPrice = 0;
            double inputCarMiles = 0;
            do
            {
                Console.Write("Enter make: ");
                inputCarMake = Console.ReadLine();
            } while (inputCarMake == "");
            do
            {
                Console.Write("Enter model: ");
                inputCarModel = Console.ReadLine();
            } while (inputCarModel == "");
            do
            {
                Console.Write("Enter year: ");
                string inputYear = Console.ReadLine();
                inputCarYear = Validator.validInteger(inputYear);
            } while (inputCarYear == 0);
            do
            {
                Console.Write("Enter price: ");
                string inputPrice = Console.ReadLine();
                inputCarPrice = Validator.validDouble(inputPrice);
            } while (inputCarPrice == 0);
            do
            {
                Console.Write("Enter mileage: ");
                string inputMileage = Console.ReadLine();
                inputCarMiles = Validator.validDouble(inputMileage);
            } while (inputCarMiles == 0);


            if (Validator.YesNoValue("Do you want to add this used car ") == "y")
            {
                Car.Cars.Add(new UsedCar(inputCarMake, inputCarModel, inputCarYear, inputCarPrice, inputCarMiles));
            }
        }

        private static void PurchaseCar()
        {
            Car.ListCars();
            int MenuNumber = 0;
            do
            {
                Console.Write("Which car would you like?  ");
                string MenuOption = Console.ReadLine();
                MenuNumber = Validator.validInteger(MenuOption);
            } while (MenuNumber < 1 || MenuNumber > Car.Cars.Count);
            Console.WriteLine(Car.Cars[MenuNumber - 1]);
            Car.RemoveCars(MenuNumber - 1);
            Console.Write("Excellent! Our finance department will be in touch shortly. Press any key to continue ...");            
            Console.ReadKey();
        }

        private static void ChangeCar()
        {
            Car.ListCars();
            int MenuNumber = 0;
            string inputCarMake = "";
            string inputCarModel = "";
            int inputCarYear = 0;
            double inputCarPrice = 0;
            double inputCarMiles = 0;
            string inputMileage = "";
            do
            {
                Console.Write("Which car would you like to change?  ");
                string MenuOption = Console.ReadLine();
                MenuNumber = Validator.validInteger(MenuOption);
            } while (MenuNumber < 1 || MenuNumber > Car.Cars.Count);
            Console.WriteLine(Car.Cars[MenuNumber - 1]);
            if (Validator.YesNoValue("Do you want to change this car ") == "y")
            {                
                do
                {
                    Console.Write("Enter make: ");
                    inputCarMake = Console.ReadLine();
                } while (inputCarMake == "");
                do
                {
                    Console.Write("Enter model: ");
                    inputCarModel = Console.ReadLine();
                } while (inputCarModel == "");
                do
                {
                    Console.Write("Enter year: ");
                    string inputYear = Console.ReadLine();
                    inputCarYear = Validator.validInteger(inputYear);
                } while (inputCarYear == 0);
                do
                {
                    Console.Write("Enter price: ");
                    string inputPrice = Console.ReadLine();
                    inputCarPrice = Validator.validDouble(inputPrice);
                } while (inputCarPrice == 0);
                do
                {
                    Console.Write("Enter mileage (for used car) or NA (for new car): ");
                    inputMileage = Console.ReadLine().Trim().ToLower();
                    if (inputMileage != "na")                    
                    {
                        inputCarMiles = Validator.validDouble(inputMileage);
                    }                    
                } while (inputCarMiles == 0 && inputMileage != "na");

                Car.RemoveCars(MenuNumber - 1);

                if(inputCarMiles == 0)
                {
                    Car.Cars.Add(new Car(inputCarMake, inputCarModel, inputCarYear, inputCarPrice));
                }
                else
                {
                    Car.Cars.Add(new UsedCar(inputCarMake, inputCarModel, inputCarYear, inputCarPrice, inputCarMiles));
                }

            }
            Console.Write("Press any key to continue ...");
            Console.ReadKey();
        }

        private static void RemoveCar()
        {
            Car.ListCars();
            int MenuNumber = 0;
            do
            {
                Console.Write("Which car would you like to remove?  ");
                string MenuOption = Console.ReadLine();
                MenuNumber = Validator.validInteger(MenuOption);
            } while (MenuNumber < 1 || MenuNumber > Car.Cars.Count);
            Console.WriteLine(Car.Cars[MenuNumber - 1]);
            if (Validator.YesNoValue("Do you want to remove this car ") == "y")
            {
                Car.RemoveCars(MenuNumber - 1);
            }                
            Console.Write("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
