using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_SUBMISSION_ASSIGNMENT

//METHOD SUBMISSION ASSIGNMENT

// Perform these actions and create a console app that includes the following:
// Create a class.
// In that class, create a method that takes two integers as parameters.
// Make one of them optional.
// Have the method do a math operation and return an integer result.
// In the Main() method of the console app, instantiate the class.
// Ask the user to input two numbers, one at a time.
// Let them know they need not enter anything for the second number.
// Call the method in the class, passing in the one or two numbers entered.
// Try various combinations of numbers on the code, including having no second number.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated the OperationsDoingMaths class
            OperationsDoingMaths mathOps = new OperationsDoingMaths();

            // Prompt user to enter two integers w/ the second entry being optional
            Console.Write("Input an integer for the first parameter: ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.Write("Input an integer for the second parameter. You may press the 'Enter' key to skip this step if you wish: ");
            string input = Console.ReadLine();

            // Default value of 1 used for the second parameter
            int Num2 = 1;

            // Deal w/ nothing being entered by user for the second parameter w/ an exception
            if (!string.IsNullOrEmpty(input))
            {
                Num2 = int.Parse(input);
            }

            // Call DoSomeMathOperation method w/ the input parameters passed & display result
            int result = mathOps.DoSomeMathOperation(Num1, Num2);
            Console.WriteLine("Result of multiplying user inputs is: " + result);

            // Give user chance to read output of result
            Console.ReadLine();
        }
        // Try various combinations of numbers on the code ' o7 '
    }
}
