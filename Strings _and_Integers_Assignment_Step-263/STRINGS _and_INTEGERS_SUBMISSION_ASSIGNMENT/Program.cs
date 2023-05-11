using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRINGS__and_INTEGERS_SUBMISSION_ASSIGNMENT
{

    // CONSOLE APP STRINGS AND INTEGERS SUBMISSION ASSIGNMENT

    // 1. Create a list of integers.
    // 2. Ask the user for a number to divide each number in the list by.
    // 3. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
    // 4. Run the code, entering in non-zero numbers as the user & Look at the displayed results.
    // 5. Run the code again, entering in zero as the number to divide by & Note any error messages you get.
    // 6. Run the code once again, entering in a string as the number to divide by & Note any error messages you get.
    // 7. Now put the loop in a try/catch block. 
    // 8. Below & outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block & continued on with program execution. 
    // 9. In the catch block, display the error message to the screen.
    // 10. Then try various combinations of user input: valid numbers, zero and a string.
    // 11. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
    // Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Create a list of integers
            //List<int> IntList = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //// 2. Ask the user for a number to divide each number in the list by
            //Console.WriteLine("Please input a whole number to divide by:");

            //// 3. Write a loop that takes each integer in the list... 

            //    // gives user a chance to input their number of choice...
            //int userNumInput = Convert.ToInt32(Console.ReadLine());

            //foreach (int Num in IntList)
            //{
            //    // then divides each int element by the number the user entered... 
            //    int divisionResult = Num / userNumInput;

            //    // and then displays the result to the screen
            //    Console.WriteLine(Num + " divided by " + userNumInput + " is " + divisionResult);
            //}
            // 4. Run the code, entering in non-zero numbers as the user & Look at the displayed results.
            // When running the code I wrote I get a 'FormatException' after division is done on the first integer and the program does not continue from there
            // I fixed this by moving the code line: " int userNumInput = Convert.ToInt32(Console.ReadLine()); " outside of the 'foreach' loop brackets that I accidentally put it inside of

            // 5. Run the code again, entering in zero as the number to divide by & Note any error messages you get.
            // When running the code and dividing by zero I get a 'DivideByZeroException'

            // 6. Run the code once again, entering in a string as the number to divide by & Note any error messages you get.
            // When running the code and giving text as the input I get a 'FormatException'


            // 7. Now put the loop in a try/catch block
            try
            {
                // 1. Create a list of integers
                List<int> IntList = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

                // 2. Ask the user for a number to divide each number in the list by
                Console.WriteLine("Please input a whole number to divide by:");

                // 3. Write a loop that takes each integer in the list... 

                // gives user a chance to input their number of choice...
                int userNumInput = Convert.ToInt32(Console.ReadLine());

                foreach (int Num in IntList)
                {
                    // then divides each int element by the number the user entered... 
                    int divisionResult = Num / userNumInput;

                    // and then displays the result to the screen
                    Console.WriteLine(Num + " divided by " + userNumInput + " is " + divisionResult);
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                // 9. In the catch block, display the error message to the screen
                Console.WriteLine("Please input a whole number. Input will be invalid if you spell your number of choice.");
                //return;  --  I removed this section of code b/c it would cause the program to exit if a second exception was caught  --  i instead put in a 'console.readline()'
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero.");
                Console.ReadLine();
            }
            //// 9. In the catch block, display the error message to the screen.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            // 8. Below & outside of try/catch block, make program print a message to the display to let you know the program has emerged from the try/catch block & continued on with program execution
            Console.WriteLine("\nProgram has exited the try/catch block and will now continue.");
            Console.ReadLine();
            //}

            // 10. Then try various combinations of user input: valid numbers, zero and a string  --  * o7 *
            // 11. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed  --  * o7 *

            // i tried moving the code on the inside of 'finally' brackets to the outside/bottom and/or deleting the finally entirely but it didn't fix this issue i'm having:
            // when the user is prompted to input a number and they enter a string, the exception is caught, but right after that when the user inputs 0 (which is also an exception to be caught) the message "Program has exited the try/catch block and will now continue" displays and the program ends instead of the "Please do not divide by zero." message. heeeeeelp! lol
        }
    }
}
