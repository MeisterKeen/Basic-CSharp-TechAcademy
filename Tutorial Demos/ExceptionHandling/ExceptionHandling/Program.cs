using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dividing the two numbers...");
            int number3 = number1 / number2;

            Console.WriteLine(number1 + " divided by " + number2 + " equals " + number3);
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message + "\nYou weirdo, type a damn number like a normal person");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message + "\nYou have created a black hole and killed us all!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + "\nSomething has gone terribly wrong, somehow.");
        }
        finally
        {
            Console.ReadLine();
        }
    }
}

