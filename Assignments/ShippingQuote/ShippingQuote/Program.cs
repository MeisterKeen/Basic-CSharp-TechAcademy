using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            // user-friendly intro:
            Console.WriteLine("Welcome to Package Express.\nPlease press enter, then follow the instructions below:");
            Console.ReadLine();

            // get the user to input a number we can understand:
            Console.WriteLine("\nPlease enter package weight in pounds." +
                "\nInput must be a whole number or a decimal. Example: '12.5'");
            // use decimal, since we're math-ing this weight into the shipping cost
            decimal pWeight = Convert.ToDecimal(Console.ReadLine());
            // could catch a cast exception here?

            // if too heavy, we give the user an error message and quits out:
            if (pWeight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            // get the dimensions, all as decimals:
            Console.WriteLine("\nPlease enter package height in inches:");
            decimal pHeight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nPlease enter package length in inches:");
            decimal pLength = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nPlease enter package width in inches:");
            decimal pWidth = Convert.ToDecimal(Console.ReadLine());

            // always give the user a cookie when he gives you correct input!
            Console.WriteLine("\nThank you! Press enter to view your quote:");
            Console.ReadLine();

            // now let's do the logic:
            // multiply the three dimensions
            decimal pProduct = pHeight * pLength * pWidth;
            decimal pDimension = pProduct * pWeight;
            decimal shipPrice = pDimension / 100;

            // show the user what he entered, so he can review it, and give him the result:
            Console.WriteLine("\nPackage Dimensions:" +
                              "\nWeight:    " + pWeight + " pounds" +
                              "\nHeight:    " + pHeight + " inches" +
                              "\nLength:    " + pLength + " inches" +
                              "\nWidth:     " + pWidth + " inches" +
                              "\n\nTotal Volume: " + pProduct + " inches" +
                              "\n\nYour estimated total for shipping this package is: $" + shipPrice);
            Console.ReadLine();





        }
    }
}
