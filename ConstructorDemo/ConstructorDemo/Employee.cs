using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int EID { get; set; }

        public Employee(string fName, string lName, int id)
        {
            fName = firstName;
            lName = lastName;
            id = EID;
        }

        public Employee(string fName, string lName)
        {
            fName = firstName;
            lName = lastName;
            EID = 0;
        }


    }
}
