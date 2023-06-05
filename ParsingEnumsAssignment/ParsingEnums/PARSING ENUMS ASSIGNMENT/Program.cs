using System;
using System.Collections.Generic;

// Perform these actions and create a console app that includes the following:
// Create an enum for the days of the week.
// Prompt the user to enter the current day of the week.
// Assign the value to a variable of that enum data type you just created.
// Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace PARSING_ENUMS_ASSIGNMENT
{
    class Program
    {
        // Create an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.WriteLine("Please input your current day of the week, then press enter: ");
                string userInput = Console.ReadLine();

                // Assign the value to a variable of that enum data type you just created
                DaysOfTheWeek currentDayOfTheWeek;

                // Parse user input & assign matching enum value to my variable
                currentDayOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);

                // Prints the user's current day
                Console.WriteLine($"Your current day of the week is: {currentDayOfTheWeek}");
            }
            // Using 'ArgumentException instead of 'Exception ex'  --  e.g. " Console.WriteLine(ex.Message); "
            catch (ArgumentException)
            {
                // Have it print "Please enter an actual day of the week.” to console if an error occurs
                Console.WriteLine("Please enter an actual day of the week.");
            }
            // Allow user to read output before closing console window
            Console.ReadLine();
        }

        /* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+- */

        // To complete this challenge, I had to do online research on how to parse enums.
        // Here is what I came up with originally before I realized I needed to use .Parse and not .TryParse:

        //// Wrap the above statement in a try/catch block
        //try
        //{
        //    // Prompt the user to enter the current day of the week
        //    Console.WriteLine("Please input your current day of the week, then press enter: ");
        //    string UserInput = Console.ReadLine();

        //    // Assign the value to a variable of that enum data type you just created
        //    DaysOfTheWeek CurrentDayOfTheWeek;

        //    // Parse user input & assign matching enum value to my variable
        //    if (!Enum.TryParse(UserInput, out CurrentDayOfTheWeek))
        //    {
        //        throw new ArgumentException("Not a valid day of the week");
        //    }
        //    // Prints the users current day
        //    Console.WriteLine($"Your current day of the week is: {CurrentDayOfTheWeek}");
        //}
        //catch (ArgumentException)
        //{
        //    // Have it print "Please enter an actual day of the week.” to console if an error occurs
        //    Console.WriteLine("Please enter an actual day of the week.");
        //}
        //// Allow user to read output before closing console window
        //Console.ReadLine();

        // ENUM NOTES:

        // EXAMPLE OF ENUM.PARSE SYNTAX:
        //string newInput = "Saturday";
        //try
        //{
        //    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), newInput);
        //    Console.WriteLine($"Parsed day: {day}");
        //}
        //catch (ArgumentException)
        //{
        //    Console.WriteLine("Invalid Day");
        //}
        //Console.ReadLine();
        // more example syntax:
        // public static T ParseEnum<T>(string value)
        //{
        //return (T) Enum.Parse(typeof(T), value, true);
        //}

        // EXAMPLE OF CASE-INSENSITIVE PARSING:
        //string userInput = "Friday";
        //DaysOfTheWeek day;
        //if (Enum.TryParse(userInput, true, out day))
        //{
        //    Console.WriteLine($"Parsed day: {day}");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid day");
        //}

        // EXAMPLE OF DEFAULT VALUE PARSING:
        //string userINPUT = "InvalidDay";
        //DaysOfTheWeek day;
        //if (Enum.TryParse(userINPUT, out day))
        //{
        //    Console.WriteLine($"Parsed day: {day}");
        //}
        //else
        //{
        //    day = DaysOfTheWeek.Monday; // Assign a default value
        //    Console.WriteLine($"Invalid day. Assigned default day: {day}");
        //}
        //Console.ReadLine();

        // EXAMPLE OF PARSING ENUM NAMES  -- 'Generic Method' syntax according to MicroSoft = " Enum.TryParse("Active", out StatusEnum myStatus); ":
        //string USERinput = "Wednesday";
        //DaysOfTheWeek day;
        //if (Enum.TryParse<DaysOfTheWeek>(USERinput, out day))
        //{
        //    Console.WriteLine($"Parsed day: {day}");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid day");
        //}
    }
}
