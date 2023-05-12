using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_ASSIGNMENT_SUBMISSION

//MAIN METHOD SUBMISSION ASSIGNMENT

// Perform these actions and create a console app that includes the following:
// Create a class.
// In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.),
// then return the answer as an integer.
// In the Main() method of the console app, instantiate the class and call the one method, passing in an integer.
// Display the result to the screen.
// Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
// In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal.
// Display the result to the screen.
// Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.
// In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.
// Display the result to the screen.

{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Calculator class
            MathOperations.Calculator calculator = new MathOperations.Calculator();

            // Prompt user to enter an integer
            Console.Write("Enter an integer: ");

            // Read user input as a string
            string userInput = Console.ReadLine();

            // Convert user input to an integer
            int NUM = int.Parse(userInput);

            // Call PerformMathOperation method with the integer input & display result
            Console.WriteLine("Result 1: " + calculator.PerformMathOperation(NUM));

            // Prompt user to enter a decimal
            Console.Write("Enter a decimal: ");

            // Read user input as a string
            userInput = Console.ReadLine();

            // Convert user input to a decimal
            decimal decimalNumber = decimal.Parse(userInput);

            // Call the PerformMathOperation method with the decimal input and display the result
            Console.WriteLine("Result 2: " + calculator.PerformMathOperation(decimalNumber));

            // Prompt user to enter a string that represents an integer
            Console.Write("Enter a string representing an integer: ");

            // Read user input as a string
            userInput = Console.ReadLine();

            // Call the PerformMathOperation method with the string input and display result
            Console.WriteLine("Result 3: " + calculator.PerformMathOperation(userInput));

            // Give user chance to read output before closing console window
            Console.ReadLine();
        }
    }
}
