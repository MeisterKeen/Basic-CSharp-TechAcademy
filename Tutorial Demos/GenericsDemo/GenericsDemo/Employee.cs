using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class Employee<T>
    {
        public string firstName;
        public string lastName;
        public int Id;
        public List<T> things = new List<T>();

        // So I tried to do this:
        // public List<T> things;
        // and that didn't work.

        public void listThings()
        {
            foreach (T thing in things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
