using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION_Handling_Pts1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception handling = deal with stuff that could go wrong in the code -- checks for errors and then does stuff to deal with them
            // the code below looks fine but when the user inputs a string it breaks the program
            // the way we deal with execption handling = a 'try/catch' block  --  I will move the current code to the inside of the 'try' brackets
            // its literal translation is "lets try this code (in the brackets) and lets catch any acceptions"  -- we're trying to catch format exceptions and assigned it to a made up variable 'ex' -- " 'ex' is of the data type 'formatexception' "

            // EXAMPLE SYNTAX:

            try
            {
                Console.WriteLine("Pick a number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick a second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing the two....");
                int num3 = num1 / num2;
                Console.WriteLine(num1 + " divided by " + num2 + " equals " + num3);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                // Message = message of the error -- will write error to screen /throw the message onto the console -- can change the 'ex.message' to be my own message & have it say whatever I want it to aka "Customizable"
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a number symbol(s) to input your whole number of choice. Do not spell the number with text.");
                // add a 'return' so that the upper code string repeats to user if they do the wrong input
                return;
            }

            // what do you do if the error/exception is not a 'formatexception'?
            // EXAMPLE:  8 / 0 (i.e. any number divided-by zero), will throw a 'DivideByZeroException' and say "Exception Unhandled - System.DivideByZeroException: 'Attempted to divide by zero.'"
            // Lets catch that 'divide by zero' exception error! (by writing a new 'catch' statement)
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't attempt to divide by zero.");
            }

            // what if the error/exception is not a 'FormatException' or a 'DivideByZeroException' or you don't currently see anything wrong?
            // create a general 'Exception'
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // another part of 'try/catch' = 'finally' -- runs no matter what i.e. if the 'try' executes w/ no exceptions, the finally will still run, & if there are exceptions, it will still run
            // the reason for this 'finally' is b/c when you 'catch' something, it sometimes stops execution of whatever is happening
            // typically you want to log an error to the database when it happens, & when you have that error u want to have something else that executes e.g taking the user to an error page
            // in the code below I put a 'console.readline' in the 'finally' brackets so that it garuntees that the readline will be called no matter what (even if i had a 'return' in the top 'catch' statement
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
