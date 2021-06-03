using System;
using System.Text;
// NOTE: System.Text is needed for StringBuilder

namespace StringFunctions
{
    class Program
    {
        static void Main()
        {
            // String concatenation:
            string str1 = "stitch a ";
            string str2 = "string ";
            string str3 = "together!";
            Console.WriteLine(str1 + str2 + str3);

            // Using a string function:
            string lower = "this was lowercase";
            Console.WriteLine(lower.ToUpper());

            // Playing with a stringbuilder:
            StringBuilder lyrics = new StringBuilder();
            lyrics.Append("\n\n\tA long, long time ago,");
            lyrics.Append("\nWhen I could still remember");
            lyrics.Append("\nHow that music used to make me smile,");
            lyrics.Append("\nAnd I knew if I had my chance,");
            lyrics.Append("\nthat I could make those people dance, and");
            lyrics.Append("\nmaybe they'd be happy for a while.");
            lyrics.Append("\nBut February made me shiver.");
            lyrics.Append("\nWith every paper I delivered");
            lyrics.Append("\nbad news on the doorstep.");
            lyrics.Append("\nI could take one more step.");
            lyrics.Append("\nI can't remember if I cried when I ");
            lyrics.Append("\nread about his widowed bride,");
            lyrics.Append("\nbut something touched me deep inside");
            lyrics.Append("\nthe day the music died.");

            Console.WriteLine(lyrics);
            Console.ReadLine();
        }
    }
}
