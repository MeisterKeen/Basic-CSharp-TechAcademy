using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print current date and time to console:
            Console.WriteLine(DateTime.Now);

            // Get a number from the user, print exact time it will be in __ hours.
            Console.WriteLine("Please enter a number of hours:");
            
            // There is an AddHours() method, which wants a double-type value as an argument.
            double input = Convert.ToDouble(Console.ReadLine());

            // I need a DateTime-type value to run the AddHours() method on:
            DateTime timeNow = DateTime.Now;

            // And here we use AddHours() on that input value:
            Console.WriteLine("In {0} hours, the time will be {1}", input, timeNow.AddHours(input));

            Console.Read();

        }
    }
}
