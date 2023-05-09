using System;
using System.Collections.Generic;

// CONSOLE APP ARRAY ASSIGNMENT:
// Create a console app that does/contains the following:
// 1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
// 2. Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
// 3. Add in a message that displays when the user selects an index that doesn’t exist.
// 4. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

// I'm going to write this code using 'if/else' statements and challenge myself to use a few other things I've learned so far -- an alternative that is easier to read would be to use the "GetElementAtIndex" method and '$' string interpolation but I'm avoiding it as I havn't learned that yet
// I feel like I may have over complicated this, but it gets the job done so it works for now :)

namespace CONSOLE_APP_ARRAY_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. a. Create a one-dimensional Array of strings 
            // 2. a. Create a one-dimensional Array of integers
            // 4. a. Create a list of strings
            string[] StringArray = { "Hallo ", "Zusammen", "!" };
            int[] IntArray = { 1, 2, 3 };
            var StringList = new List<string>() { "Hier", "ist", "eine", "Liste" };

            // 1. b. Ask user to select an index of the Array 
            Console.WriteLine("Please input an index number then press enter to display string array: ");
            int IndexString = int.Parse(Console.ReadLine());

            // 1. c. then display the string at that index on the screen
            // using 'if/else' statements to deal with possible user inputs
            if (IndexString >= 0 && IndexString < StringArray.Length)
            {
                // optional interpolation example (I reckon I'm guessing a bit for this): Console.WriteLine($"The string at index {stringIndex} is {stringArray[stringIndex]}");
                Console.WriteLine("The string at index " + IndexString + " is " + StringArray[IndexString]);
            } 
            else
            {
                // 3. Add in a message that displays when the user selects an index that doesn’t exist
                Console.WriteLine("The Index number you selected is out of range.");
            }

            // 2. b. Ask user to select an index of the Array
            Console.WriteLine("Please input an index number to display the integer at that index: ");
            int IntIndex = int.Parse(Console.ReadLine());

            // 2. c. Then display the integer at that index on the screen
            if (IntIndex >= 0 && IntIndex < IntArray.Length)
            {
                Console.WriteLine("The integer at index " + IntIndex + " is " + IntArray[IntIndex]);
            }
            else
            {
                // 3. Add in a message that displays when the user selects an index that doesn’t exist
                Console.WriteLine("The Index number you selected is out of range.");
            }

            // 4. b. Ask user to select an index of the list
            Console.WriteLine("Please input an index number to display that index within string list: ");
            int IndexList = int.Parse(Console.ReadLine());

            // 4. c. Then display the content at that index on the screen
            if (IndexList >= 0 && IndexList < StringList.Count)
            {
                Console.WriteLine("The string at index " + IndexList + " is " + StringList[IndexList]);
            }
            else
            {
                // 3. Add in a message that displays when the user selects an index that doesn’t exist
                Console.WriteLine("The Index number you selected is out of range.");
            }

            // ensure user has time to read outputs
            Console.ReadLine();
        }
    }
}
