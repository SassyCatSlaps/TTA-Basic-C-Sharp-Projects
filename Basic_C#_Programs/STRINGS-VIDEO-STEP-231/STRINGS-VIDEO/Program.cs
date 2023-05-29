using System;
using System.Text;

namespace STRINGS_VIDEO
{
    class Program
    {
        static void Main(string[] args)
        {
            //LEARNING STRINGS  -- Functions/Methods attached to strings: backslashes, tabing, '@' symbol, .Contains, .length, ToUpper, ToLower, and new lines
            //string name = "vikko";
            //string quote = "The greeting was a \"Hello\". \nIt was a nice greeting. \n \t I hope to hear it again.";
            //string fileName = "C:\\User\\Vikko";
            //string newFileName = @"C:\USer\Vik";

            ////Useful when parsing files
            //bool trueOrFalse = name.Contains("v");
            //trueOrFalse = name.EndsWith("k");

            //find out how many characters there are in a string = string.Length;
            //int length = name.Length;
            //name = name.ToUpper();
            ////name = name.ToLower();

            //Console.WriteLine(name);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(quote);
            //Console.ReadLine();

            // if you keep on concatenating/updating strings (making new strings in memory) it can slow down your program eventually
            // C# has something a class called "string builder" that helps with this  --  it is a dynamic object aka expandable w/o loss of performance
            // had to put "using System.Text;" in at the top to make this work

            // EXAMPLE:
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Vik");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
