﻿using System;
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
            firstName = fName;
            lastName = lName;
            EID = id;
        }

        public Employee(string fName, string lName): this(fName, lName, 0)
        {
        
        }


    }
}
