using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Perform these actions and create a console app that includes the following:
// Prints the current date and time to the console.
// Asks the user for a number.
// Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the current date and time to the console
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);

            // Asks the user for a number
            Console.WriteLine("Please input a number: ");
            string userInput = Console.ReadLine();

            // Need the user input to be read as a number
            int NumToAdd = Convert.ToInt32(userInput);

            // Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2
            DateTime futureDT = currentDateTime.AddHours(NumToAdd);
            Console.WriteLine($"The exact time in {NumToAdd} hours will be: {futureDT}");

            // Allow for user to read output before closing window
            Console.ReadLine();
        }
    }
}
