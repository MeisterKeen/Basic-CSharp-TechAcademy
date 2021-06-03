using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable:

            const string stringy = "Hello, I am a string!";

            Console.WriteLine(stringy);
            Console.Read();

            // Create a variable using the keyword "var":

            var stringamento = "Hey-hey! I, too, am a string!";

            Console.WriteLine(stringamento);
            Console.Read();

            // Chain two constructors together: I'm going to create a class "Employee";

            var jDobbs = new Employee("John", "Dobbs");

            var hDoolittle = new Employee("Helen", "Doolittle", 101);

            // We have a constructor that wants an ID number, and another one that just substitutes a default "0"

            // Just to check it:
            Console.WriteLine(jDobbs.EID);
            Console.Read();

        }
    }
}
