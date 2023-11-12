using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCarsLab
{
    public class Validator
    {
        public static string YesNoValue(string DisplayMessage)
        {
            while (true)
            {
                Console.Write($"{DisplayMessage} (y/n)? ");
                string answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer) && (answer.Trim().ToLower() == "n" || answer.Trim().ToLower() == "y"))
                {
                    return answer.Trim().ToLower();
                }
                Console.Write("Invalid entry, please enter y/n. Press any key .....");
                string AnyKey = Console.ReadLine();
            }
        }

        public static double validDouble(string userEntry)
        {
            try
            {
                double num = double.Parse(userEntry);
                return num;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + "Try again.");
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public static int validInteger(string userEntry)
        {
            try
            {
                int num = int.Parse(userEntry);
                return num;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + "Try again.");
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
