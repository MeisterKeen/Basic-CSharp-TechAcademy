using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();
            Console.ReadLine();
            
            // Okay... so I instantiate an Interface AS a new Employee() object...?
            IQuittable employee2 = new Employee();
            // And SOMEHOW that works.
            // What the hell.
          
            // So does Quit() work?
            employee2.Quit();
            // Yes it does.

            // And THAT is Polymorphism?
            // ...interesting.

        }
    }
}
