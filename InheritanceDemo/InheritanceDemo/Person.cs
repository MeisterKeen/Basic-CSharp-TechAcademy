using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        // At this point I'm just making everything public, because I keep getting access level errors
        // I am sure that there is no scenario in which making everything public to everything else
        // could ever backfire.

        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
