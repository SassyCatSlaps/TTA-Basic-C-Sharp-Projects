using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// STRUCT ASSIGNMENT:

// Perform these actions and create a console app that includes the following:
// Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
// In the Main() method, create an object of data type Number and assign an amount to it.
// Print this amount to the console.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code

namespace StructAssignment
{
    class Program
    {
        // Create a struct called Number and give it the property “Amount” and have it be of data type decimal
        struct Number
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            // In the Main() method, create an object of data type Number...
            Number NumObj = new Number();

            // ...and assign an amount to it  --  e.g "assign an amount to the "Amount" property of the Number object"
            NumObj.Amount = 25.5m;

            // Print this amount to the console
            Console.WriteLine($"Amount: {NumObj.Amount}");

            // Give user moment to read output  --  Outputs: 'Amount: 25.5'
            Console.ReadLine();
        }
    }
}
