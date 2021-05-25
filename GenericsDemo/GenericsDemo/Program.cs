using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> JDavis = new Employee<string>();
            JDavis.firstName = "Joe";
            JDavis.lastName = "Davis";
            JDavis.Id = 1001;
            JDavis.things.Add("thingOne");
            JDavis.things.Add("thingTwo");
            JDavis.things.Add("thingThree");

            // tried doing this with a line that looked like:
            //JDavis.things = { "thingOne", "thingTwo", "thingThree" };
            // but for some reason it gave me an error.

            // now it's giving me a DIFFERENT error, because "things" is... null?
            
            // OH I GET IT -- I had to actually initialize the empty generic list within the Employee class.


            JDavis.listThings();
            Console.ReadLine();

            // now let's do this again:

            Employee<int> MGarcia = new Employee<int>();
            MGarcia.firstName = "Michael";
            MGarcia.lastName = "Garcia";
            MGarcia.Id = 1002;
            MGarcia.things.Add(55);
            MGarcia.things.Add(12);
            MGarcia.things.Add(3);
            MGarcia.things.Add(-22);

            MGarcia.listThings();
            Console.ReadLine();

        }
    }
}
