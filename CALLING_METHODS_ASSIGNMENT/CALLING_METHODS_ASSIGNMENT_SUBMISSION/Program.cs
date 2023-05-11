using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_ASSIGNMENT_SUBMISSION

// CALLING METHODS SUBMISSION ASSIGNMENT

// Perform these actions and create a console app that includes the following:
// Create a class.
// In that class, create three methods, each of which will take one integer parameter in and return an integer.
// The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.
// In the Main() program, ask the user what number they want to do the math operations on.
// Call each method in turn, passing the user input to the method.
// Display the returned integer to the screen.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class by right-clicking on project in the Solution Explorer & select "Add" --> "Class"  --  then go over to the new class file/tab to complete next step

            // In the Main() program, ask the user what number they want to do the math operations on
            Console.WriteLine("Please input a number to perform maths operations on it:");
            int userNumberSelection = Convert.ToInt32(Console.ReadLine());

            //Call each method in turn, passing the user input to the method
            int resultEins = Maths.MultByFive(userNumberSelection);
            int resultZwei = Maths.AddSixteen(userNumberSelection);
            int resultDrei = Maths.SubTen(userNumberSelection);

            //Display the returned integer to the screen
            Console.WriteLine("Your chosen number " + userNumberSelection + " multiplied by 5 is: " + resultEins);
            Console.WriteLine("Your selected number " + userNumberSelection + " added to by 16 is : " + resultZwei);
            Console.WriteLine("Your designated number " + userNumberSelection + " subtracted by 10 is: " + resultDrei);

            // give user chance to read the output before closing console app window
            Console.ReadLine();
        }
    }
}
