using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // the Thing named 'thing' is a new Thing()
            // sometimes coding is like baby-talk
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            // SAY HIS NAME!

            Console.ReadLine();

        }
    }
}
