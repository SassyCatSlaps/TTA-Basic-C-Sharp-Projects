using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_ASSIGNMENT_SUBMISSION
{
    public class MathOperations
    {
        // Create a class to encapsulate the math operations
        public class Calculator
        {
            // Method that takes an integer, performs a math operation, and returns an integer
            public int PerformMathOperation(int number)
            {
                // Add 10 to the input number and return the result
                return number + 10;
            }

            // Overloaded method that takes a decimal, performs a math operation, then returns an integer
            public int PerformMathOperation(decimal number)
            {
                // Multiply the input number by 2 & return result as an integer
                return (int)(number * 2);
            }

            // Overloaded method that takes a string, converts it to an integer, performs a math operation, & returns an integer
            public int PerformMathOperation(string numberString)
            {
                // Try to convert the input string to an integer
                if (int.TryParse(numberString, out int number))
                {
                    // Square the input number and return the result
                    return number * number;
                }
                else
                {
                    // If input string is not a valid integer, return 0
                    return 0;
                }
            }
        }
    }
}
