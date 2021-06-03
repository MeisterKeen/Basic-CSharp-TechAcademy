using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class:
            Class1 class1 = new Class1();

            Console.WriteLine("Please input a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you. Please input another number, or press enter.");
            string input = Console.ReadLine();

            if (input != "") // console input should be an empty string if the user just pressed enter.
            {
                Console.WriteLine("The result is: " + class1.TwoInt(num1, Convert.ToInt32(input)));
            }
            else
            {
                Console.WriteLine("The result is: " + class1.TwoInt(num1));
            }

            Console.ReadLine();

        }
    }
}
