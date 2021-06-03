using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee : Person
    {
        public int ID;

        // poor orphaned property never got used by anybody!
    }
}
