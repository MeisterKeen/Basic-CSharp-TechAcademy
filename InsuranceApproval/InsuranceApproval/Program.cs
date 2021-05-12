using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            // intro:
            Console.WriteLine("Car Insurance Approval Questionnaire\n\nPlease Press Enter To Begin");
            
            // Start with getting user input:
            Console.WriteLine("\nEnter your age in years (please enter a number):");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHave you ever had a DUI? (Please enter 'True' or 'False')");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\nHow many speeding tickets do you have? (please enter a number)");
            int userTickets = Convert.ToInt32(Console.ReadLine());

            // Crunchy logic!
            // first: is the applicant of age?
            bool validAge = userAge >= 15;
            // no DUIs?
            bool validDUI = userDUI == false;
            // No more than 3 speeding tickets
            bool validTickets = userTickets < 4;

            if (validAge && validDUI && validTickets) 
            {
                Console.WriteLine("\n\nCongratulations! You are qualified for car insurance.");
            }
            else 
            {
                Console.WriteLine("\n\nUnfortunately you may not be qualified for our standard insurance services." +
                    "\nPlease speak to an adjustor to review your qualifications and determine your options.");
            }

            Console.ReadLine();
            
        }
    }
}
