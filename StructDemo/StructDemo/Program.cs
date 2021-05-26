using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we're demonstrating how to create and use structs.
            // We have a "Number" struct with decimal property "amount":

            // instantiating a Number object, and giving it an amount:
            Number number = new Number();
            number.amount = 44.5m;

            // writing the amount to console:
            Console.WriteLine(number.amount);
            Console.ReadLine();
        }
    }
}
