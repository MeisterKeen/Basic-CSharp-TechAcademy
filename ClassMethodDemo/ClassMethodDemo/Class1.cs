using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Class1
    {
        // so it's a void method, but it's supposed to output something...?
        public void Method1(int num1, out int result)
        { // I feel like this is going to hurt some coder's soul, somewhere.
            result = num1 / 2;
        }

        // This one's static, so I can call it directly without the instantiated object:
        public static void Method2(int num3, out int result1, out int result2)
        {
            result1 = num3 * 10;
            result2 = num3 * num3;
        }

        // this one takes a string, so it should be legal to overload it:
        public static void Method2(string str1)
        {
            Console.WriteLine("You said: " + str1);
        }

    }
}
