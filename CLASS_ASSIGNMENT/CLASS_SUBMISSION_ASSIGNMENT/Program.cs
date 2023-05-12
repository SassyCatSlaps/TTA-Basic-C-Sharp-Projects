using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CLASS SUBMISSION ASSIGNMENT

// Perform these actions and create a console app that includes the following:
// Create a class. In that class, create a void method that outputs an integer.
// Have the method divide the data passed to it by 2.
// In the Main() method, instantiate that class.
// Have the user enter a number.
// Call the method on that number.
// Display the output to the screen. It should be the entered number, divided by two.
// Create a method with output parameters.
// Overload a method.
// Declare a class to be static.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            Mathmagical maths = new Mathmagical();

            // Prompt user to enter a number
            Console.Write("Input a number: ");

            // Read user input as a string
            string userInput = Console.ReadLine();

            // Convert user input to an integer
            int userNumber = int.Parse(userInput);

            // Call the method on user input and display the output
            Console.WriteLine("The result of dividing " + userNumber +  " by 2 is " + maths.divideByTwo(userNumber));

            // Call the method with output parameters and display the output
            int Output;
            maths.divideByTwoWithOutput(userNumber, out Output);
            Console.WriteLine("The result of dividing " + userNumber + " by 2 is "  + Output);

            // Call the overloaded method and display the output
            int OverloadedResult = maths.divideByTwo(userNumber, 3);
            Console.WriteLine("The result of dividing " + userNumber + " by 3 is " + OverloadedResult);

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }

    // Declare a static class
    public static class MathWorker
    {
        // Declare a static method that adds two integers
        public static int Add(int x, int z)
        {
            return x + z;
        }
    }
}