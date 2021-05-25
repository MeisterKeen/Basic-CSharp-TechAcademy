using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            // First we ask the user for input:
            Console.WriteLine("Please enter a day of the week:");
            // Store the input in "input"
            string input = Console.ReadLine();
            // Then we run out of ideas, steal some code from StackOverflow!
            try
            {
                // So enums have a built-in Parse() method that can convert strings to enumerated values:
                Day day = (Day)Enum.Parse(typeof(Day), input, true);
                // bonus: that "true" switch makes it case-insensitive! input "mOnDaY" evaluates as enum "Monday"

                // This writeline is here just so I can see if the thing did the thing:
                Console.WriteLine("You selected: {0}", day);
                // it did the thing!
            }
            catch (ArgumentException ex)
            {
                // Dear User: You Have Committed A Fucky-Wucky. Please Unfuck. Thank You.
                Console.WriteLine(ex.Message + "\nPlease enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
    // Here's our enum data type of Day, 7 possible values:
    public enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
