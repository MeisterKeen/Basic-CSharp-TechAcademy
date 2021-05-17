using System;

namespace BranchingDemo
{
    class Program
    {
        static void Main()
        {
            // 1. Do a boolean comparison using a while statement:

            // Ok, I'm going to try to do this in the simplest, cleanest way I can think of...

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("It's true!");
                break;
            }
            // Lol!! All I did was write a very clunky "if" statement using a while loop.
            // Still technically works.


            // 2. Do a boolean comparison using a do while statement:
            do
            {
                Console.WriteLine("It's still true!");
                break;
            }
            while (isTrue);
            // Behold! An EVEN CLUNKIER "if" statement!

            // just to make sure this do/while loop is behaving the way I think it is:

            do
            {
                Console.WriteLine("It's not true!");
                break;
            }
            while (!isTrue);
            // WAIT, WHAT? isTrue is true, the "while()" statement is supposed to control the bit
            // inside the "do" block, right? But it printed "It's not true" -- WHY?
            // oh wait
            // right
            // it's because "do" makes the program execute the loop at least once, no matter
            // what the "while()" statement is saying. So...


            do
            {
                Console.WriteLine("Yes it is, it's TOTALLY true");
                isTrue = false;
                break;
            }
            while (!isTrue);

            if (isTrue) 
            {
                Console.WriteLine("If you see this line, something is wrong");
            }

            // OK nice, now I get it.


            // Fun thought: how many unneccesary while loops could be replaced with
            // "if/else" branches? Are those less expensive than loops? Seems like
            // while loops have more potential to break. And for me, if/else branches
            // are way easier to think with.
            // How many ways are there to skin this cat?

            Console.ReadLine();

        }
    }
}
