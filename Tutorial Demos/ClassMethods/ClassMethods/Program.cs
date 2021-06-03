using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input from user:
            Console.WriteLine("Hello! Please enter a whole number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // All the results in one big long writeline:
            Console.WriteLine("\nThank you!\n" +
                                "\n" + num1 + " divided by 3 is:  " + Threes.Divide(num1) +
                                "\nWith a remainder of:  " + Threes.Modulus(num1) +
                                "\n" + num1 + " cubed is:  " + Threes.Cube(num1));
            Console.ReadLine();




            // So this was tricky! I didn't quite understand how to pass an argument into
            // a class method and get a result back out of it. I had to clarify a few bits
            // of syntax before it made sense.

            // This assignment came out so simple, but it took me a couple of hours.

            // I think it's easier for me to think of a class as a container -- it contains
            // blueprints to create an object, but it also contains functions. I can use
            // classes almost the way you use modules in Python.

        }
    }
}
