using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // first we instantiate two Employee objects and give them values:

            Employee abcd = new Employee();
            abcd.firstName = "Test";
            abcd.lastName = "McTesterson";
            abcd.Id = 1001;

            Employee efgh = new Employee();
            efgh.firstName = "Testley";     // Test is short for Testley
            efgh.lastName = "McTesterson";
            efgh.Id = 1001;

            // Now let's see if our overloaded operator works:

            Console.WriteLine(abcd == efgh);
            Console.ReadLine();

            // I'll be damned, that actually worked. That could be REALLY handy.

        }
    }
}
