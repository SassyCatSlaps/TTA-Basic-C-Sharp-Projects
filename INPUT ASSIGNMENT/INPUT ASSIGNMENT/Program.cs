using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace INPUT_ASSIGNMENT
{

// Perform these actions and create a console app that includes the following:
// Asks the user for a number.
// Logs that number to a text file.
// Prints the text file back to the user.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number
            Console.WriteLine("Please input a numer:");
            string userInput = Console.ReadLine();

            // Logs that number to a text file
            string filePath = (@"C:\Users\vlarm\Logs\log.txt");
            File.WriteAllText(filePath, userInput);

            // Reads contents of log file
            string LoggedText = File.ReadAllText(filePath);

            // Prints the text file back to the user

            Console.WriteLine("The file contents are: ");
            Console.WriteLine(LoggedText);

            // Allow for read and user prompted exit
            Console.WriteLine("Press any key to exit console window");
            Console.ReadKey();
        }
    }
}
