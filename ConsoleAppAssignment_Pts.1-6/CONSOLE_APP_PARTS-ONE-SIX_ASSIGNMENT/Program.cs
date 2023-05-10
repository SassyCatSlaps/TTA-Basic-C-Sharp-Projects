using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_PARTS_ONE_THROUGH_SIX_ASSIGNMENT
{

    //CONSOLE APP ASSIGNMENT PART-ONE

    //Create a console app that does/contains the following:
    // 1. A one-dimensional array of strings.
    // 2. Ask the user to input some text.
    // 3. A loop that iterates through each string in the array and adds the user's text input to the end of each string.
    // This step will not output anything to the console, but will update each array element by appending the user's text.
    // 4. Then create a second loop that prints off each string in the array one at a time.

    //CONSOLE APP PART TWO ASSIGNMENT

    // Add the following to your console app and perform these actions:
    // An infinite loop.
    // Save your code.
    // Fix the infinite loop so that it will execute properly.
    // Add comments to your code indicating how the infinite loop was fixed.
    // Save and execute your code.

    // CONSOLE APP PART THREE ASSIGNMENT

    // Add the following to your console app and perform these actions:
    // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
    // Save and execute your code.
    // Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
    // Save and execute your code.

    // CONSOLE APP PART FOUR ASSIGNMENT

    // Add the following to your console app and perform these actions:
    // A list of strings where each item in the list is unique.
    // Ask the user to input text to search for in the list.
    // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
    // Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 
    // Add code that stops the loop from executing once a match has been found.
    // Save and execute your code.

    // CONSOLE APP PART FIVE ASSIGNMENT

    // Add the following to your console app and perform these actions:
    // A list of strings that has at least two identical strings in the list.
    // Ask the user to select text to search for in the list.
    // Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text. Ensure to remove any break statements that may prevent your code from returning multiple matches.
    // Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. (You do not need to provide any additional chances for the user to enter text.)
    // Save and execute your code.

    // CONSOLE APP PART SIX ASSIGNMENT

    // Add the following to your console app and perform these actions:
    // Create a list of strings that has at least two identical strings in the list.
    // Create a foreach loop that evaluates each item in the list, & displays a message showing the string & whether or not it has already appeared in the list.
    // Example: if you had a list of letters: {“A”, “B”, “C”, “D”, “C”}, you could have the following print to the  screen:
    // A - this item is unique
    // B - this item is unique
    // C - this item is unique
    // D - this item is unique
    // C - this item is a duplicate
    // Save and execute your code.


    //// ********* I refered to my notes from my 'namespace STRING_ASSIGNMENT' && 'namespace ARRAYS_AND_LISTS' && 'namespace CONSOLE_APP_ARRAY_SUBMISSION_ASSIGNMENT' && 'namespace STRING_ASSIGNMENT' + more for these assignments ********* ////


    class Program
    {
        static void Main(string[] args)
        {
            // PART-ONE:

            // 1. create a one-dimensional array of strings
            string[] stringArray = { "Das ", "ist ", "ein ", "fabelhafte ", "Saite " };

            // 2. ask the user to input some text
            Console.WriteLine("Bitte geben Sie einen Text ein, und drücken Sie dann die Eingabetaste.");

            // code that allows user to give input and stores their input in the variable 'userInput'
            string userInput = Console.ReadLine();

            // 3. create a loop that iterates through each string in the array and adds the user's text input to the end of each string
            // I'm going to use a 'for' and 'foreach' loop here to iterate through each string in the 'stringArray' and append the 'userInput' to the end of each element/string  --  has no output to console
            for (int i = 0; i < stringArray.Length; i++)
            {
                // had to look this part up  --  used the += operator to append the users input to end of current string at index 'i' within the 'stringArray'
                stringArray[i] += userInput;
            }

            // 4. create a second loop that prints off each string in the array one at a time
            // this is where I will utilize a 'foreach' loop
            foreach (string part in stringArray)
            {
                Console.WriteLine(part);
            }
            // give user a chance to read output
            Console.ReadLine();

            /* *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*- */

            // PART TWO:

            // add an infinite loop, run the code, and then fix the infinite loop so it runs properly
            // there are a few way to make a loop infinite - the two ways I found were: 1. by creating a 'for' loop  &&  2. by creating a 'while (true)' loop - I will attempt to demonstrate both below
            // to fix these infinity loops by only adding to the code (i could obviously just change the code to make this easier), simply add a break statement to the while(true) loop
            // and to fix the for loop I could do the same thing or i could even add a counter but I would have to alter the original code to do so

            // infinity v1
            while (true)
            {
                // there is not condition for false! this is always true and thus, no way to break the logic loops
                Console.WriteLine("To infinity, and beyond!");

                // lets give the user a way out! here I'm going to give the user some instructions and then take those instructions and break the loop with them... this is a little silly but it totally works
                Console.WriteLine("To come back to earth and exit program, type 'make it end' and then press enter.");

                // grab user input to exit program
                string exitInput = Console.ReadLine();

                // the condition below states: "if the user input assigned to 'exitInput' matches 'make it end' then break and exit the program"
                if (exitInput == "make it end")
                {
                    // allows the program to close
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown input. Enter the correct text or you will loop forever.");
                    // the statement 'continue' will cause the loop to restart from the beginning... so mean
                    continue;
                }
            }

            // infinity v2

            // here I simply made a condition that will always be true  -- 'z is greater than or equal to zero' will cause loop entrapment and forever execution since z is set to zero from the jump 
            // C#/VS actually threw a warning here cuz its smart
            // the easiest way for me to fix this one is going to just be to change it to avoid more code lines and creating a new variable

            // original infinity code: for (int z = 0; z >= 0; z++)
            // new slightly modified code to end infinity  --  the string will repeat printing to console until x is greater than 10 (at 11 times basically) and then it will end
            for (int x = 0; x <= 10; x++)
            {
                // original infinity code: Console.WriteLine("Infinity strikes again! Nooooooo!");
                Console.WriteLine("Back on earth, all is well again.");
            }
            // give user a chance to read output
            Console.ReadLine();

            /* *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*- */

            // PART THREE:

            // create loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator

            // chosing to use a 'for' loop  --  I've already done this in my infinity loop but we'll do it again  --  to make this more interesting I looked up how to use a 'format specifier = {0}' that will be over-riden with a new value once prog. runs
            // in this loop, the format specifier '{0}' will be replaced by the value stored in 'z' during each iteration -- 'z' is set to zero when the program starts  --  this took me a sec to figure out so hopefully its not too janky
            // each "Pass" is basically an iteration counter
            for (int z = 0; z < 10; z++)
            {
                Console.WriteLine("Pass {0}", z);
            }
            Console.ReadLine();

            // add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator
            // too easy! I'll do what I did above and plug in a new operator  --  this will print the below string about 16 times before it allows the user to exit
            for (int y = 0; y <= 15; y++)
            {
                Console.WriteLine("Iteration count {0}", y);
            }
            // give user a chance to read output
            Console.ReadLine();

            /* *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*- */

            // PART FOUR:

            // create a list of strings where each item in the list is unique
            List<string> newList = new List<string>();
            newList.Add("One of my ");
            newList.Add("favorite videogames is ");
            newList.Add("Bloodbourn. It ");
            newList.Add("is basically ");
            newList.Add("an example ");
            newList.Add("of perfection.");

            // I didn't look up how to display this list to the user until assignment part 4 when I looked it up

            // next ask user to input text to search for in the list
            Console.WriteLine("Please input some text to search for a word or letter in the list:");
            string userTextSearch = Console.ReadLine();

            // a big issue I ran into here is that my code breaks if user doesn't input anything and presses enter! So I looked up what to do in that instance and this is what I came up with:
            // CHECK IF USER INPUT = VALID
            while (string.IsNullOrWhiteSpace(userTextSearch))
            {
                Console.WriteLine();
                userTextSearch = Console.ReadLine();
            } 

            // then add a loop that iterates through the list and then displays the index of the list item that contains matching text on the screen  --  i.e "iterate throught the list and find a match"

            // I originally used a 'for' loop but later realize I could make it into a nicer 'foreach' and get rid of my original 'else' statement which wasn't being executed once loop was broken with the 'if' condition being true:
            bool userTextMatchFound = false;
            foreach (string item in newList)
            {
                if (item.Contains(userTextSearch))
                {
                    Console.WriteLine("I found a match for the text you entered: {0}", item);
                    userTextMatchFound = true;
                    break;
                }
            }
            // add code to check if the user input text that isn't on the list and, if they did, tell the user their input is not on the list
            if (!userTextMatchFound)
            {
                Console.WriteLine("Sorry, you input is not an item on the list.");
            }
            // give user a pause before program continues some more
            Console.ReadLine();


            // first attempt that didn't pass all my tests:
            // I just used a boolean and a 'for/if' loop to get this done - I used the '.Contains' method on each string to check for match -  ouchy, my brain broke a bit here lol
            //bool userTextMatchFound = false;
            //for (int M = 0; M < newList.Count; M++)
            //{
            //    if (newList[M].Contains(userTextSearch))
            //    {
            //        Console.WriteLine("I found a match for the text you entered at index {0}", M);
            //        userTextMatchFound = true;
            //        // add in code that stops the loop from executing once a match has been found = to exit loop = 'break'
            //        break;
            //    }
            //    // after that add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list
            //    // I also though it would be fun to mess with the user by not having the program end until they put in a correct input - I used 'continue' to do that
            //    else
            //    {
            //        if (!userTextMatchFound)
            //        {
            //            Console.WriteLine("Your input is not a part of the list. Please try again.");
            //            continue;
            //        }
            //    }
            //}

            /* *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*- */

            // PART FIVE:

            // create a list of strings that has at least two identical strings in the list 
            List<string> NAMES = new List<string>() { "Vikko", "Lynn", "Garth", "Ruby", "Moe", "Vikko" };

            // then ask user to select text to search for in the list
            Console.WriteLine("Please select some text to search for from this list:\n");

            // I'm nice and gave user the list here using 'foreach'  --  in my first try I did this completely wrong not realizing I would need a 'foreach' loop and tried to do it with just 'Console.WriteLine(NAMES);' 
            foreach (string name in NAMES)
            {
                Console.WriteLine(name);
            }

            string userSearchInput = Console.ReadLine();

            // next, create a loop that iterates through the list and then displays the indices of the items matching the user-selected text // be sure to remove any break statements that may prevent your code from returning multiple matches


            // In my first try I used a 'foreach' loop here that wasn't keeping track of the indexs -- it looked like this:
            //foreach (string name in NAMES)
            //{
            //    if (name == Console.ReadLine())
            //    {
            //        Console.WriteLine(name);
            //    }

            // in this new loop below that iterates over the list, I keep track of the index of each matching element and print it out
            bool MatchFOUND = false;
            for (int N = 0; N < NAMES.Count; N++)
            {
                if (NAMES[N] == userSearchInput)
                {
                    Console.WriteLine("There is a match that has been found at index {0}", N);
                    MatchFOUND = true;
                }
            }

            // second attempt using 'if' logic
            if (!MatchFOUND)
            {
                Console.WriteLine("Sorry but your input does not match anything on the list.");
            }
            // give user a moment to read output
            Console.ReadLine();


            // the else statement that I had after my original 'foreach' statement would always execute whenever the user's input does not match the first element in the list
            // now my new/current loop uses a flag variable to keep track of whether any matches were found, and only display the "not found" message after the loop has finished executing
            // this is what my first attempt looked like:
            //else
            //{
            //    // one does not need to provide any additional chances for the user to enter text - but I did anyway
            //    Console.WriteLine("Sorry but your input does not match anything on the list. Please try again.");
            //    continue;
            //}

            /* *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*- */

            // PART FIVE:

            // create a list of strings that has at least two identical strings in the list
            List<string> SmellDescriptions = new List<string>() { "rot", "floral", "stinky", "sweet", "dank", "burnt", "fragrant", "rot" };

            // here I added in 2 empty lists 'singleItems' & 'duplicate'  --   this helps me keep track of the unique and duplicate elements within the list
            List<string> singleItems = new List<string>();
            List<string> duplicate = new List<string>();

            // create a 'foreach' loop that evaluates each item in the list, & displays a message showing the string & whether or not it has already appeared in the list

            // my 'foreach' loop uses some 'if/else' statements and uses the '.Contains' method to check for duplicates
            foreach (string description in SmellDescriptions)
            {
                if (!singleItems.Contains(description))
                {
                    Console.WriteLine(description + ": this here element is unique and does not repeat within the list.");
                    singleItems.Add(description);
                }
                else
                {
                    if (!duplicate.Contains(description))
                    {
                        Console.WriteLine(description + ": this here element is a duplicate!");
                        duplicate.Add(description);
                    }
                }
            }
            // give user pause before ending program
            Console.ReadLine();
        }
    }
}