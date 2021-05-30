using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Punch in some numbers or something, would you?");
            string userInput = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(@"C:\Users\KeenMeister\Desktop\userText.txt", true))
            {
                writer.WriteLine(userInput);
            }

            Console.WriteLine("I have logged your entry. \nThe total content of the file is as follows:\n\n");
            Console.WriteLine(File.ReadAllText(@"C:\Users\KeenMeister\Desktop\userText.txt"));
            Console.Read();
        }
    }
}
