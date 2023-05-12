using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// METHOD CLASS SUBMISSION ASSIGNMENT

// Perform these actions and create a console app that includes the following:
// Create a class.
// In that class, create a void method that takes two integers as parameters.
// Have the method do a math operation on the first integer and display the second integer to the screen.
// In the Main() method of the console app instantiate the class.
// Call the method in the class, passing in two numbers.
// Call the method in the class, specifying the parameters by name.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


namespace METHOD_CLASS_ASSIGNMENT_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the newly created class
            MathMathBby mathOps = new MathMathBby();

            // Prompt user to input the first number
            Console.WriteLine("Please enter the first number:");

            // Read the first number input from the user
            int Num1 = int.Parse(Console.ReadLine());

            // Prompt the user to input the second number
            Console.WriteLine("Please enter the second number:");

            // Read the second number input from the user
            int Num2 = int.Parse(Console.ReadLine());

            // Call the method in the class & pass in two numbers
            mathOps.mathMagic(Num1, Num2);

            // Call the method in the class & specifying the parameters by name
            mathOps.mathMagic(Num1: Num2, Num2: Num1);

            // Allow user to read the output before closing console window
            Console.ReadLine();
        }
    }
}
