using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        // a one-dimensional array of strings:
        string[] strings = { "", "", "" };
        // turns out empty strings work fine.

        Console.WriteLine("\nHey, user! Input some random text:");
        string userText = Console.ReadLine();

        // traverse the array, add userText to each array element:
        for (int i = 0; i < strings.Length; i++)
        {
            strings[i] = strings[i] + userText;
            // There's no Add or Append method for arrays,
            // so I'm just using basic string concatenation here.
        } 

        // traverse the array, print each array element:
        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine(strings[i]);
        }

        Console.ReadLine();

        // A not-so-infinite loop:
        while (true)
        {
            Console.WriteLine("To infinity, AND BEYOND!");
            break;
        }
        // I feel like I could write a lot of programmer jokes with "while (true)"

        Console.ReadLine();


        // Using a <= comparison in a loop:

        int hits = 4;

        for (int i = 0; i <= hits; i++)
        {
            Console.WriteLine("Stop hitting yourself");
        }

        Console.ReadLine();


        // list of unique strings:
        List<string> fingers = new List<string>() { "index", "ring", "middle", "pinky", "thumb" };

        // prompt the user to 'search' for an item in the list:
        Console.WriteLine("\n\nHello, User! Please search for a type of finger in list 'fingers':");
        string userSearch = Console.ReadLine();
        
        // we flip this to "true" if the user's input matches one of the strings.
        bool foundIt = false;
        
        // this works, but it feels clunky.
        for (int i = 0; i < fingers.Count; i++)
        {
            if (fingers[i] == userSearch)
            {
                foundIt = true;
                Console.WriteLine("\nFound it! Fingers list element #" + i + " is " + fingers[i]);
                break;
            }
        }

        // if the user's search didn't match an item:
        if (foundIt == false)
        {
            Console.WriteLine("\nItem not found, sorry :(");
        }

        Console.ReadLine();


        // This one's tricky. Make a list of strings, and there have to be a pair of duplicates in the list:
        List<string> colors = new List<string>() { "red", "green", "blue", "yellow", "blue", "orange", "violet"};

        // We have to compare this list to itself, and check for duplicates.

        // I'm going to initialize another list that we can compare the list items to:
        List<string> compare = new List<string>();


        foreach (string color in colors)
        {
            foreach (string thing in compare)
            {
                if (color == thing)
                {
                    Console.WriteLine(color + " is a duplicate");
                    break;
                }
                Console.WriteLine(color + " is not a duplicate.");
            }
            compare.Add(color);
        }
        Console.ReadLine();

        // LOL!
        // The funny thing is that this ACTUALLY WORKS, it just prints too many strings
        // because it's printing a string for every check it makes, instead of printing
        // the result after it does its check loop.

        // I'm gonna turn this in as it is, because it's funny. And then I'll figure out
        // how to fix it. I think I would use a boolean to store the result every time it
        // checks for duplicates, and then reset it at the beginning of each new list
        // element it starts to check.











        // notes from videos below:

        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //// Initialize the sentry, give the comparison statement, define the iteration operation.
        //for (int i = 0; i < testScores.Length; i++) 
        //{
        //    if (testScores[i] > 85) 
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int i = 0; i < names.Length; i++) 
        //{
        //    Console.WriteLine(names[i]);
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores) 
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing est score:" + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //    if (name == "Jesse")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}

        //Console.WriteLine(passingScores.Count); // count is like length() but for lists
        //Console.ReadLine();
    }
}

