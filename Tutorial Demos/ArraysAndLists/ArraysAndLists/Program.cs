using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Here is our array of strings:
        string[] strArray = { "Zero!", "One!", "Two!", "Three!", "Four!", "Five!", "Six!", "Seven!", "Eight!", "Nine!", "Ten!" };

        // Ask for user input:
        Console.WriteLine("Please input a number between zero and ten:");
        int strNum = Convert.ToInt32(Console.ReadLine());

        // I actually wanted to write a try/catch for this, but this seems trickier than when I did it in Javascript.
        if (strNum > 10 || strNum < 0)
        {
            Console.WriteLine("\nYou have entered a number that was not between zero and ten!" +
                                "\nThis has broken my entire fragile program, which will now quit.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        // This uses the user-input number as the array index to print:
        Console.WriteLine(strArray[strNum]);
        

        // Similar array of integers:
        int[] intArray = { 1234, 5678, 9098, 7654, 3212, 3456, 7890, 9876, 5432, 1234, 5678 };

        // always reward the user with an "attaboy" when he gets the input right:
        Console.WriteLine("\nWell done!\n\nNow please input another number between zero and ten:");
        int strNum2 = Convert.ToInt32(Console.ReadLine());

        // Your crime spree is over, villain!
        if (strNum2 > 10 || strNum2 < 0)
        {
            Console.WriteLine("\nYou fool! You have entered an illegal number!" +
                                "\nWait where you are, the authorities will be along to arrest you shortly.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        // 
        Console.WriteLine(intArray[strNum2] + "\n\nWell done! That is the end of this program.");
        Console.ReadLine();



        // below are notes from the video:

        //          ARRAYS

        //// creating and populating an array:
        //int[] numArray = new int[5]; // it wants to know the length of the array when I create it.
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// Here's a shorthand way to create an array:
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };
        //// Here, it automatically knows the length of the array by the number of items I put in it.

        //// an even more concise way to create an array:
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //// Once created, I can change specific items in the array:
        //numArray2[5] = 650;
        //// I can't change the array's length, but I can add items to it.


        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        //          LISTS

        //// lists are much more flexible:
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //List<string> strList = new List<string>();
        //strList.Add("Hello");
        //strList.Add("World");


        //// you can create byte arrays to store large items like images.
        //byte[] byteArray = new byte[ ];
        //// you don't have to guess at the size; you'd initialize the array with the intended item.
    }
}

