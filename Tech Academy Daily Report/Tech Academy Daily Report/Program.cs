using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Academy_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a "daily report" application which will receive and store
            // answers from students (and do absolutely nothing with them

            // We start with an intro:
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
            
            // For each of these, we're going to save the student's answer to a string variable.
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False.\"");
            string needHelp = Console.ReadLine();
            // I would use a boolean data type but you just KNOW that someone is going to enter something
            // unreadable and I don't want to write the try/catch block to handle this right now.

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string pozExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string numHours = Console.ReadLine();
            // Theoretically I could use an integer type here but I'm more likely to get an answer that can't
            // really be stored as an int.

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Hand a great day!");
            Console.ReadLine();

            // Maybe I could finish this by populating an email message
            // with all these string variables and send them along to 
            // the instructor email account?
        }
    }
}
