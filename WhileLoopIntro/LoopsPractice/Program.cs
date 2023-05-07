using System;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //its best to avoid 'while-loops' b/c it can cause a program to never end
            //check for wide variety of possible inputs! - switch statements!  //  writing examples of switch statements
            // case = "asking the question, did this happen? did this happen? how about this?"
            Console.WriteLine("Guess a number?");
            int Num = Convert.ToInt32(Console.ReadLine());

            //put it in loop until user guesses the right number = use a "while loop" - creating a boolean for this expression
            //bool isGuessed = false;
            bool isGuessed = Num == 12;
            //while(isGuessed == false) -- easier way to write this syntax below  --  ' ! ' is the same as _____ == false
            // **** the problem with while loops if that if the user gueses correct on the first try the program never enters the while-loop/switch block and the program doesnt output anything after that *****
            // C# has a solution for this called a 'do-while-loop'  --  put a 'do' infront of the 'while' and then put the switch statement block inside of the 'do' curly brackets

            do
            {
                ////"while isGussed = false, then do what's in the curly brackets"  --  moved switch statement to the inside of these brackets--and then moved them again to the inside of the newly added 'do' curly brackets
                switch (Num)
                {
                    //"if Num = 62, then give ____ output to user"
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        //part of keeping the code going is to ask for the users input again - not super sext program construction due to not being DRY lol
                        Console.WriteLine("Guess a number?");
                        Num = Convert.ToInt32(Console.ReadLine());
                        //putting "break" stops the switch statement from continuing
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        Num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        Num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. This is correct!");
                        //changing the logic for if user guesses correct
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a number?");
                        Num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            //{
                // moved the switch statement out of the spot once the 'do' was added
            //}
            Console.Read();
        }
    }
}
