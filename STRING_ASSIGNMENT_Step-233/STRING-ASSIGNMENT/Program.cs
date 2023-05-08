using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// STRING ASSIGNMENT:

// Create a console app that does/includes the following:
// 1. Concatenates three strings.
// 2. Converts a string to uppercase.
// 3. Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.

namespace STRING_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            // SYNTAX: StringBuilder sb = new StringBuilder();
            // create an instance of the 'StringBuilder' class and use its 'Append' method to append the strings

            string name = "Lynn ";
            //name = "Vik";
            string boss = "The Soul of Cinder ";
            string game = "Dark Souls 3";
            string words = name + boss + game;
            words = words.ToUpper();

            Console.WriteLine(words);
            Console.ReadLine();
            //sb.Append("Lynn");
            //sb.Append("The Soul of Cinder");
            //sb.Append("Dark Souls 3");

            //sb = sb.ToUpper();

            // call the 'ToString' method to convert the 'StringBuilder' object into a regular string

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Vik. ");
            sb.Append("I hate this assignment. ");
            sb.Append("I wish given more examples of how to use stringbuilder before being asked to use it myself. ");
            sb.Append("I don't like having to blindly do something without fully understanding it. ");
            sb.Append("Vik wishes they understood the uses of this better after their research and is salty now.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
