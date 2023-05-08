using System;

namespace Console_App_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //// here is an example of a very simple while-loop
            //// this loop takes a variable and assigns its integer value to zero - it then states that while that variable 'Num' is less than 10, print that number to the screen, add 1 to it, then run it again until the variable exceeds 10.
            //// output will print 0,1,2,3,4,5,6,7,8,9
            //int Num = 0;
            //while (Num < 10)
            //{
            //    Console.WriteLine(Num);
            //    Num++;
            //}

            //// here is an example of a simple 'do/while' loop  --  this basically does the same thing as the code above but the code block is executed before the condition is tested
            //int Number = 0;
            //do
            //{
            //    Console.WriteLine(Number);
            //    Number++;
            //}
            //while (Number < 21);

            /* *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* */

            // CONSOLE APP SUBMISSION ASSIGNMENT

            // 1. Create a boolean comparison using a while statement.
            int Num = 2;
            bool isMoreThanTen = false;
            // code uses while loop that will continue until the 'isMoreThanTen' value becomes 'True'  --  ' ! ' = while isMoreThanTen == false  --  the ' ++ ' tells the loop to add on 1 everytime to the value that is stored in 'Num'
            // used 'if/else' statement to make boolean comparison and to continue the loop as needed
            while (!isMoreThanTen)
            {
                if (Num > 10)
                {
                    isMoreThanTen = true;
                }
                else
                {
                    Num++;
                }
            }
            // this line will print once Num is more than 10, meaning that the 'Num' output will be 11
            Console.WriteLine("Number value is now more than ten: " + Num);
            Console.Read();

            // 2. Create a boolean comparison using a do while statement.
            // here is the same code from above put into a 'do/while loop'
            // the 'do-while loop' is similar to a 'while loop', but the condition is checked at the end of loop instead of at beginning
            int NUM = 2;
            bool isGreaterThanTen = false;

            do
            {
                if (NUM > 10)
                {
                    isGreaterThanTen = true;
                }
                else
                {
                    NUM++;
                }
            }
            while (!isGreaterThanTen);

            Console.WriteLine("Number is now greater than ten: " + NUM);
            Console.Read();


            /* *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* */

            // EXTRAS:

            // here is an example of a more complicated while-loop that I tried out for extra practice  --  I actually found it easier to write it as a 'do/while loop' but did it this way my first try
            // here I have created a second version of my console app "SwitchStatementChallenge" that prompts user input & then uses a switch statement to decide what season that month/number-input is associated with.
            // I am also practicing using a few new concepts and keywords I have come upon during my research which include, "int.try.parse", " ! ",  and "out"
            // user input is stored in the variable 'userNum' -- this variable will then be used in my switch expression
            // declaring the variable 'season' to hold/store the 'season' string input associated with the month-number the user enters

            //int userNum = 0;
            //string season = "";
            //// the while-loop will ask the user to enter a number between 1 and 12 and will repeat this request until user enters a valid input
            //while (userNum < 1 || userNum > 12)
            //{
            //    Console.WriteLine("Input a number between 1 and 12, then press enter.");
            //    // 'int.TryParse()' method = used to check if user input is a valid integer, and to assign the parsed integer to 'userNum' variable if the parsing = successful
            //    // the bool 'parseSuccess' variable will be used to store the return value of 'int.tryparse'
            //    // 'out' = keyword in C# used for passing a parameter by referenc  --   value of userNum passed as a reference to the 'int.TryParse()' method
            //    // in summary, my line of code reads a string from the console, then tries to convert it to an integer using 'int.TryParse()', then stores the integer value (if successful) in the 'userNum' variable, and lastly sets the 'parseSuccess' variable to true or false depending on whether the conversion was successful or not
            //    bool parseSuccess = int.TryParse(Console.ReadLine(), out userNum);

            //    // '!' = "if/while parseSucess == false"
            //    if (!parseSuccess)
            //    {
            //        Console.WriteLine("Invalid input, please enter a valid number.");
            //    }
            //}
            ////swicth statement uses the 'userNum' value to cycle through switch options and match the correct case, it then assigns matching 'season' variable to it
            //switch (userNum)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        season = "Winter";
            //        break;
            //    case 4:
            //    case 5:
            //    case 6:
            //        season = "Spring";
            //        break;
            //    case 7:
            //    case 8:
            //    case 9:
            //        season = "Summer";
            //        break;
            //    case 10:
            //    case 11:
            //    case 12:
            //        season = "Autumn";
            //        break;
            //}
            ////concatenated output to user (as opposed to using 'interpolation', which is considered more ledgable and simpler to understand)
            //Console.WriteLine("The month associated with the number " + userNum + " is considered part of the " + season + " season.");
            //Console.ReadLine();
        }
    }
}
