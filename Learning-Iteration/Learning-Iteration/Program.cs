using System;
using System.Collections.Generic;

namespace Learning_Iteration_Step245_247
{
    class Program
    {
        //  'string[] args' = passing in a string array as an argument to the main function
        static void Main(string[] args)
        {
            // note: lists are much easier to iterate over but we're doing the hard way first lol
            // iteration = going through a list of items and doing something with each of those items
            // first create an integer array and instanciate it - here we have some madeup test scores
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            // next lets find out who passed this madeup test - we're going to say that anything over an 85 is a passing grade
            // we will create a for loop to do this that has 3 conditions (for loops dont take up much code space):
            // first condition is going to be the starting value = starting value = 0
            // the next condition is how long is the for loop going to go = "Until what is false"  -- for as long as 'i' is less than the length of the testScores array
            // the last condition is what we want to do after each time the for loop runs - it will perform action for exactly how many 'items' have been put into testScores
            // each condition is seperated with ' ; '  --  what you want to do is located inside the {} curly braces of the for loop
            for (int i = 0; i < testScores.Length; i++)
            {
                // we want to log to the console all the passing scores so lets use an if statement for this  --  thing located in the [] is what we are targeting
                if (testScores[i] > 85)
                {
                    // if testscore is greater than 85, then do x (log/print the passig scores)
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            // ensure user has time to read the output
            Console.ReadLine();

            // lets do this again but with a string array
            string[] names = { "Vikko", "Lynn", "Garth", "Ruby", "Moe" };
            // even though its a string you still have to call the data type integer b/c the indexs are represented by numbers
            for (int n = 0; n < names.Length; n++)
            {
                // lets log any names that match "Lynn" / or just print them to the console
                //if (names[n] == "Lynn")
                //{
                //    Console.WriteLine(names[n]);
                //}
                Console.WriteLine(names[n]);
            }
            Console.ReadLine();


            // now lests do iteration with a list!  --  .NET framework has a lot of built in functions to sort and parse through a list

            // first create an integer list using the syntax below (List<int> = a class | new = creating a new object/ new instance of that class)
            List<int> TESTscores = new List<int>();
            // manually add items into the list
            TESTscores.Add(98);
            TESTscores.Add(99);
            TESTscores.Add(81);
            TESTscores.Add(72);
            TESTscores.Add(70);

            // now lets iterate over this list using a 'foreach loop'  --  keep an eye on your pluras and singles for the naming of variables
            // 'foreach' works just like a for loop but its simpler to work w/ and easier to read
            foreach (int score in TESTscores)
            {
                if (score >= 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }
            Console.ReadLine();

            // lets do another one! (with a string) 
            List<string> Names = new List<string>() { "Vikko", "Lynn", "Garth", "Ruby", "Moe" };

            foreach (string name in Names)
            {
                if (name == "Vikko")
                {
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();


            // what if something meets a condition and you want to add it to another list?  --  we're going to loop through the test scores and for eacg one that passes we'll add it to the new passsingScores list
            // here we have an integer list of test scores... now lets do a foreach loop over it
            List<int> TestSCORES = new List<int>() { 98, 99, 12, 74, 23, 99 };
            // next create a blank list  --  do not have to define how big list is going to be unlike in an array
            List<int> passingScores = new List<int>();
            
            foreach (int score in TestSCORES)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            // print how many passing scores there were after iteration is complete using .Count = a property of List that tells you how many elements there are in List
            // e.g. the console will output a number like '2' or '3' depending on how many passing scores there are
            // .Length is for Arrays | .Count is for Lists  --  properties do basically the same thing tho
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();


            /* *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* */


            // SIX-PART ASSIGNMENT EXAMPLE:

            // Assignment Part 1
            // Three strings to concatenate:
            string lineOne = "Beware; ";
            string lineTwo = "for I am fearless, ";
            string lineThree = "and therefore powerful";

            // Concatenating the three strings:
            Console.WriteLine(lineOne + lineTwo + lineThree);

            // Assignment Part 2
            // A string to be converted to uppercase:
            string x = "who controls the past controls the future.";

            // Converting string to uppercase print:
            Console.WriteLine(x.ToUpper());

        }
    }
}
