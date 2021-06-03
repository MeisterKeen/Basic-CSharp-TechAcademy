using System;


namespace AnonymousIncomeCalc
{
    class Program
    {
        static void Main()
        {   
            // This block gathers the user input needed:
            Console.WriteLine("Anonymous Income Comparison Program\n\nPress Enter To Begin");
            Console.ReadLine();
            Console.WriteLine("\nPerson One:\nPlease Input Your Hourly Pay Rate:");
            decimal P1HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nNow Please Input Your Average Hours Worked Per Week:");
            decimal P1HoursWorked = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n\nPerson Two:\nPlease Input Your Hourly Pay Rate:");
            decimal P2HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nNow Please Input Your Average Hours Worked Per Week:");
            decimal P2HoursWorked = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nThank you. Press Enter To View Results:");
            Console.ReadLine();


            // Now let's do the actual mathy logic:

            // Start with P1. Hourly times hours equals weekly income:
            decimal P1WeeklyInc = P1HourlyRate * P1HoursWorked;
            // 52 weeks in a year:
            decimal P1YearlyInc = 52 * P1WeeklyInc;

            // Second verse:
            decimal P2WeeklyInc = P2HourlyRate * P2HoursWorked;
            decimal P2YearlyInc = 52 * P2WeeklyInc;

            // We don't REALLY need a variable for weekly income, but I would write it
            // this way so that I could add a "show my weekly income" widget later

            // Now we need the boolean comparitor:
            bool P1morethanP2 = P1YearlyInc > P2YearlyInc;

            // Now let's tell the users:
            Console.WriteLine("Person One Yearly Income Is: $" + P1YearlyInc);
            Console.WriteLine("Person TWo Yearly Income Is: $" + P2YearlyInc);

            // Just to flex, I'm going to handle this with an if/else:
            if (P1morethanP2) 
            {
                Console.WriteLine("\nPerson One Makes More Money Than Person Two.");
            }
            else 
            {
                Console.WriteLine("\nPerson One Does Not Make More Money Than Person Two.");
            }

            Console.WriteLine("\n\nEnd Of Program.");
            Console.ReadLine();
            // I considered using MCP's "End Of Line" bit from Tron.
        }
    }
}
