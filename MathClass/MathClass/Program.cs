using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the Mather class:
            Mather mather = new Mather();

            // if I tried really hard, I could probably come up with a more roundabout way to add two numbers:
            int num1 = mather.AddTen(5);

            Console.WriteLine("Five plus ten is equal to {0}", num1);

            int num2 = mather.AddTen(5.5m);

            Console.WriteLine("Five and a half times ten is {0}", num2);

            Console.WriteLine("\nNow you try. Enter a whole number:");
            string input = Console.ReadLine();

            int num3 = mather.AddTen(input);
            Console.WriteLine("Okay. If you divide {0} by 5, the remainder will be {1}", input, num3);

            Console.ReadLine();

        }
    }
}
