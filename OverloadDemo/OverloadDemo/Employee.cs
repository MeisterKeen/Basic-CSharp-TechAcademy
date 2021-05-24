using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDemo
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int Id;

        public static Boolean operator ==(Employee n, Employee m)
        {
            return n.Id == m.Id;
        }
        // It won't let me do this unless I define the matching "is NOT equal to" operator:
        public static Boolean operator !=(Employee n, Employee m)
        {
            return n.Id != m.Id;
        }
    }
}
