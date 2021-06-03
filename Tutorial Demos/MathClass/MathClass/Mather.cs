using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    // It's called a Mather because it Maths.
    class Mather
    {
        public int AddTen(int num1)
        {
            return num1 + 10;
        }

        public int AddTen(decimal num2)
        {
            // AddTen(decimal) does not add ten!
            decimal result = num2 * 10;
            return Convert.ToInt32(result);
        }

        public int AddTen(string num3)
        {
            int result = Convert.ToInt32(num3);
            return result % 5;
        }
    }
}
