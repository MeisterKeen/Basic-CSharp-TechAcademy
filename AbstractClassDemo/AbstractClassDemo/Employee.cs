using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Employee : Person
    {
        // What's the object-oriented way to get rich?
        public override void SayName()
        {
            Console.WriteLine("This person's name is {0} {1}", firstName, lastName);
        }
        // Inheritance!
    }
}
