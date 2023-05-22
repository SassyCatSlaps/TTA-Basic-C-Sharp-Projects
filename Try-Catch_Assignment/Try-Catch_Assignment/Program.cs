using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TRY/CATCH ASSIGNMENT:
// Perform these actions and create a console app that includes the following:
// Ask the user for their age.
// Display the year the user was born.
// Exceptions must be handled using “try/catch.”
// Display appropriate error messages if the user enters zero or negative numbers.
// Display a general message if an exception was caused by anything else.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceptions must be handled using “try/catch.”
            try
            {
                // Ask the user for their age
                Console.WriteLine("Please input your age in integer format.");
                int userAge = int.Parse(Console.ReadLine());

                // Display appropriate error messages if the user enters zero or negative number
                if (userAge <= 0)
                {
                    throw new ArgumentException("Input invalid. Your age input must be a positive number.");
                }

                // Calculating the year user was born using DateTime
                int currentDate = DateTime.Now.Year;
                int yearUserBorn = currentDate - userAge;

                // Display the year the user was born
                Console.WriteLine($"You were born in {yearUserBorn}. Neat!");
            }
            catch (Exception ex)
            {
                // Display a general message if an exception was caused by anything else
                Console.WriteLine("Something went wrong. Error: " + ex.Message);
            }
            // Give user chance to read output before closing console window
            Console.Read();
        }
    }
}