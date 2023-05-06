

//write and execute C# code that utilizes if, else if and else statements and displays output to the console

using System;

namespace ConditionalStatementChallenge
{
    class Program
    {
        static void Main()
        {
            //writing a statement that I remember doing when learning if/else in JS
            //asks, "is user old enough to vote in the states and do they count as a senior citizen?"
            // int Age = 32;

            // if (Age < 18)
            // {
            //     Console.WriteLine("You are too young to vote citizen!");
            // }
            // else if (Age >= 18 && Age < 55)
            // {
            //     Console.WriteLine("You are of legal age to vote but are not a senior citizen.");
            // }
            // else
            // {
            //     Console.WriteLine("You are of voting age and are a senior citizen.");
            // }

            // '!=' Operator - 'does not equal'  //  answers question: "Does the value on my left NOT equal the value on my right?"
            string Name = "Vikko";

            if (Name != "Sassy");
            {
                Console.WriteLine("Your name is not Sassy");
            }

            //Second ' ! ' Example:
            if (1 != 5)
            {
                Console.WriteLine("Everything is normal and checks out.");
            }
            else
            {
                Console.WriteLine("The bizarro multiverse cometh!");
                Console.ReadLine();
            }
        }
    }
}