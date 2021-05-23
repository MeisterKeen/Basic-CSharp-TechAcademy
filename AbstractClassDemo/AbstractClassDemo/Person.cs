using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public abstract class Person
    {

        // Unlike me, this person CAN have class!

        public string firstName;
        public string lastName;

        public abstract void SayName();
    }
}
