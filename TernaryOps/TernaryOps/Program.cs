﻿using System;


namespace TernaryOps
{
    class Program
    {
        static void Main()
        {

            // Standard if/else statements:

            //int roomTemperature = 70;

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temp");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temp");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is colder than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("Something's fucky!");
            //}
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("it is colder than room temperature");
            //}
            //Console.ReadLine();

            // Ternary branching:

            //int a = 5;
            //int b = 7;
            //string tern = a > b ? "a is bigger" : "a is not bigger";
            //Console.WriteLine(tern);
            //Console.ReadLine();

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp" : "it is not room temp.";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            Console.WriteLine("what is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "Awesomesauce." : "You suck!";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
