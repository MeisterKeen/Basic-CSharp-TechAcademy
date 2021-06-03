using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMathClass
{
    class Class1
    {
        // second argument has a default value:
        public int TwoInt(int num1, int num2 = 5)
        {
            return num1 * num2;
        }
    }
}
