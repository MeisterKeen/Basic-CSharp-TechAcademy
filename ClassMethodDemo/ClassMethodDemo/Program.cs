using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating the object.
            Class1 class1 = new Class1();

            // Ask the user for a number input:
            Console.WriteLine("Please input a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2;

            // calling the void Method1 with an out keyword instead of a return:
            class1.Method1(num1, result: out num2);
            Console.WriteLine("{0} divided by 2 is {1}", num1, num2);

            // pretty sure I have to instantiate these variables first, right?
            int num3;
            int num4;

            
            Class1.Method2(num1, out num3, out num4);
            Console.WriteLine("{0} times 10 is {1}\n{0} times itself is {2}", num1, num3, num4);

            // Same method name, totally different method function:
            Console.WriteLine("\n\nType some words in here:");
            Class1.Method2(Console.ReadLine());
            // overloading is weird.

            Class2.Method3();

            Console.ReadLine();




        }
    }
}
