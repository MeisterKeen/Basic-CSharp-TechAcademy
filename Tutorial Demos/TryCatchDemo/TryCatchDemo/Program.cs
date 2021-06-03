using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input:
            Console.WriteLine("Hello! Please enter your age in years:");
            //bool validAnswer = false;
            // At first I was thinking I might put this all in a while loop that runs as long as validAnswer is false,
            // and then logic this thing out with if/else statements. But the assignment asked for a try/catch block.

            try
            {
                // I found it easiest to put the whole thing in one try/catch:
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge <= 0)
                {
                    // First thing we check: did the user give a negative or zero value?
                    throw new ArgumentException();
                }
                DateTime birthYear = DateTime.Now.AddYears(-userAge);
                Console.WriteLine("Your birth year was " + birthYear.Year);
            }
            catch ( FormatException )
            {
                // If the input can't be formatted as an int, we catch this error:
                Console.WriteLine("Your entry was invalid, please enter only whole numbers.");
                Console.Read();
                return;
            }
            catch ( ArgumentException )
            {
                // This should catch what the if statement above is throwing:
                Console.WriteLine("Your age cannot be zero or negative!");
                Console.Read();
                return;
            }
            catch
            {
                // Not sure how a user could ever get here, but:
                Console.WriteLine("Something went wrong! Please try again or seek technical assistance.");
                Console.Read();
                return;
            }

            Console.Read();
        }
    }
}
