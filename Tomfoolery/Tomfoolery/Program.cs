using System;


namespace Tomfoolery
{
    class Program
    {
        static void Main(string[] args)
        {
            //string String1 = "Hello ";
            //string String2 = "World!";

            //Console.WriteLine(String1 + String2);
            //Console.ReadLine();


            //int total = 5 + 10;
            //int othertotal = 12 + 22;
            //int combined = total + othertotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            // Trying out various math operators

            //int difference = 10 - 5;
            //Console.WriteLine("Five minus Ten = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0; // the ".0" is necessary here so that the compiler will handle 
            //Console.WriteLine(quotient);    // these numbers as floats, otherwise they're integers.
            //Console.ReadLine();

            //int remainder = 11 % 2; // called "modulus"
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;
            ////bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //// Console app assignment:

            //// first we're going to prompt the user for input:
            //Console.WriteLine("Let's do some math! Please Enter a Number:");
            //// We need the user's input to convert to a long integer. This is where the failure may happen.
            //long inputNumber1 = Convert.ToInt64(Console.ReadLine());
            //// We'll add 25 to the input,
            //long result1 = inputNumber1 * 50;
            //// and output a string that tells the user what we did:
            //Console.WriteLine(inputNumber1 + " multiplied by 50 is: " + result1);
            //Console.ReadLine(); // pause for the user

            //// Now we'll duplicate this code for some other operations:
            //Console.WriteLine("This time we'll add 25 to your number:");
            //int inputNumber2 = Convert.ToInt32(Console.ReadLine());
            //int result2 = inputNumber2 + 25;
            //Console.WriteLine(inputNumber2 + " plus 25 is: " + result2);
            //Console.ReadLine();

            //Console.WriteLine("input a number, which will be divided by 12.5:");
            //// I expect some floaty results so we're using doubles here
            //double inputNumber3 = Convert.ToDouble(Console.ReadLine());
            //double result3 = inputNumber3 / 12.5;
            //Console.WriteLine(inputNumber3 + " divided by 12.5 is: " + result3);
            //Console.ReadLine();

            //Console.WriteLine("input a number, and we'll check if it's greater than 50:");
            //// integers should be fine here
            //int inputNumber4 = Convert.ToInt32(Console.ReadLine());
            //bool result4 = inputNumber4 > 50;
            //Console.WriteLine("is " + inputNumber4 + " greater than 50? Answer: " + result4);
            //Console.ReadLine();

            //Console.WriteLine("we'll divide this one by 7, and show you the remainder:");
            //double inputNumber5 = Convert.ToDouble(Console.ReadLine());
            //double result5 = inputNumber5 % 7;
            //Console.WriteLine(inputNumber5 + " divided by 7, remainder is: " + result5);
            //Console.ReadLine();

            Console.WriteLine(true != false);
            Console.ReadLine();
        }
    }
}
