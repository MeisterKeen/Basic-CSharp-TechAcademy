using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // We need a list of 10 employees. So we have an Employee class.
            // So let's just build out ten of those objects:

            Employee jDobbs = new Employee()
            {
                firstName = "Joe", lastName = "Dobbs", Id = 1001
            };

            Employee sGarett = new Employee()
            {
                firstName = "Sue", lastName = "Garett", Id = 1002
            };

            Employee hSimpson = new Employee()
            {
                firstName = "Homer", lastName = "Simpson", Id = 1003
            };

            Employee cDavis = new Employee()
            {
                firstName = "Chip", lastName = "Davis", Id = 1004
            };

            Employee aHoxha = new Employee()
            {
                firstName = "Adil", lastName = "Hoxha", Id = 1005
            };

            Employee lLeonard = new Employee()
            {
                firstName = "Lenny", lastName = "Leonard", Id = 1006
            };

            Employee wSmithers = new Employee()
            {
                firstName = "Waylon", lastName = "Smithers", Id = 1007
            };

            Employee cCarlson = new Employee()
            {
                firstName = "Carl", lastName = "Carlson", Id = 1008
            };

            Employee rMarlow = new Employee()
            {
                firstName = "Robert", lastName = "Marlow", Id = 1009
            };

            Employee jBlow = new Employee()
            {
                firstName = "Joe", lastName = "Blow", Id = 1010
            };

            List<Employee> employeeList = new List<Employee>()
            {
                jDobbs, sGarett, hSimpson, cDavis, aHoxha, lLeonard, wSmithers, cCarlson, rMarlow, jBlow
            };
            // Behold, a list of Employees!



            // Now let's make a new list to catch the Joes:
            List<Employee> Joes = new List<Employee>();
            // And a loop that grabs the Joes:
            foreach (Employee employee in employeeList)
            {
                if (employee.firstName == "Joe")
                {
                    Joes.Add(employee);
                    Console.WriteLine("JOE DETECTED! Employee {0} {1} please report for de-Joeification.", employee.firstName, employee.lastName);
                }
            }
            // I have said "employee" so many times in my head that the word is losing its meaning. HELP.
            Console.ReadLine();





            // Okay, cool, that foreach loop worked. So Now let's lambdafy it.
            // we need someplace to put the Joes:
            List<Employee> AlsoJoes = new List<Employee>();


            //AlsoJoes.Add(employeeList[x => x.firstName == "Joe"]);

            //AlsoJoes.Add(x => employeeList[x] => x.firstName == "Joe");

            AlsoJoes = employeeList.Where(x => x.firstName == "Joe").ToList();

            Console.WriteLine(AlsoJoes[0].firstName + " " + AlsoJoes[1].firstName);
            Console.ReadLine();
            // Okay, so I want to add an item from employeeList...
                // I want to grab the indexed item from employeeList IF the item's firstName value is "Joe"
                    // I think the lambda expression I wrote resolves to a boolean, not an int...
                        // How the hell do I get the integer I want?
                             // Where or how or in what way do I create the equivalent of an "if" statement here?
            
            
            // ...and now I am very, very lost.
            // Lambda functions SUCK. I do not like them, I do not understand them, their structure doesn't
            // make sense to me. they were an awful problem back in JavaScript, and now they still don't make
            // any damn sense.

            // I need an undercut. A more basic reference that explains, in a step-by-step fashion, what each
            // symbol and bit of syntax related to lambda functions actually does. I cannot READ a lambda func
            // and get any idea what it does, how in hell do you expect me to write one?

            // And why does every online resource start with the assumption that I know what the => fat arrow
            // means? I have spent --hours-- on this!

            // Doesn't anyone actually DEFINE THE DAMN TERMS somewhere?!?!?!

            // Is it just me, or do others hang up on this, too? I HATED this topic back in JavaScript, I just
            // copy-pasted them in when I had to and otherwise worked around them.

        }
    }
}
