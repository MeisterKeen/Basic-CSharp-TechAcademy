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

            // No, this doesn't work:
            //IQuittable quitter = new IQuittable();

            // I can't instantiate an Interface.
            // HOWEVER, I have implemented IQuittable through the Employee class above.
            // Thus the following should work:
            
            employee.Quit();

            // and the program will not execute the following ReadLine():
            Console.ReadLine();

            // Is that what's being asked for?
            // am I missing the point somehow?

        }
    }
}
