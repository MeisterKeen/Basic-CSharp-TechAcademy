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
                firstName = "Joe", lastName = "Dobbs", Id = 1
            };

            Employee sGarett = new Employee()
            {
                firstName = "Sue", lastName = "Garett", Id = 2
            };

            Employee hSimpson = new Employee()
            {
                firstName = "Homer", lastName = "Simpson", Id = 3
            };

            Employee cDavis = new Employee()
            {
                firstName = "Chip", lastName = "Davis", Id = 4
            };

            Employee aHoxha = new Employee()
            {
                firstName = "Adil", lastName = "Hoxha", Id = 5
            };

            Employee lLeonard = new Employee()
            {
                firstName = "Lenny", lastName = "Leonard", Id = 6
            };

            Employee wSmithers = new Employee()
            {
                firstName = "Waylon", lastName = "Smithers", Id = 7
            };

            Employee cCarlson = new Employee()
            {
                firstName = "Carl", lastName = "Carlson", Id = 8
            };

            Employee rMarlow = new Employee()
            {
                firstName = "Robert", lastName = "Marlow", Id = 9
            };

            Employee jBlow = new Employee()
            {
                firstName = "Joe", lastName = "Blow", Id = 10
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
            // we need someplace to put the Joes, so we instantiate AlsoJoes:
            List<Employee> AlsoJoes = new List<Employee>();



            AlsoJoes = employeeList.Where(x => x.firstName == "Joe").ToList();

            // I am utterly disgusted with how long this took me.
            // Not only was I confused about Lambda functions, but 
            // See that little ToList() there at the end?
            // Yah. THAT was my problem.
            // So when I thought I had the lambda expression right, I STILL got an error, and I thought it was because of the expression!
            // I just spent two days researching Lambda functions thinking my Goddamn brain was broken.




            // I hate programming.




            // I should be a truck driver.

            // Or maybe a line cook?



            // Maybe I should join a tugboat crew and move barges around a harbor.



            List<Employee> MoreJoes = new List<Employee>();

            MoreJoes = employeeList.Where(x => x.Id > 5).ToList();
            

            // I could sell wicker furniture on Etsy! People do stuff like that, right?


            // It's okay, I don't need to work in IT, I'll buy a house when I'm 70.

        }
    }
}
