using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetMoreMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class:
            Class1 class1 = new Class1();

            // Call the method, passing in two arguments:
            class1.TwoInt(num1: 5, num2: 7);

            // and that's it.
            Console.ReadLine();

            // I'm getting the hang of the flow of data, here. I think I can work with this.
        }
    }
}
