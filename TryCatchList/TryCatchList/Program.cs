using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // list of numerators - numbers to be divided
                List<int> numerators = new List<int> { 5, 77, 43, 94, 28 };
                // get the denominator from the user
                Console.WriteLine("Enter a number to divide a list of numbers by!");
                int userDenomerator = Convert.ToInt32(Console.ReadLine());
                // loop which divides all the numerators by the userDenomenator:
                foreach (int number in numerators)
                {
                    Console.WriteLine(number / userDenomerator);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Whoops! You can't divide by zero!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only enter whole numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!\nPlease remove all curses, sacrifice a goat and try again.");
            }

            Console.WriteLine("Program executed successfully. Press enter to quit.");
            Console.ReadLine();
        }
    }
}
