using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Perform these actions and create a console app that includes the following:
// Create a const variable.
// Create a variable using the keyword “var.”
// Chain two constructors together.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace CONSTRUCTOR_ASSIGNMENT
{
    class Program
    {
        // Create a const variable
        const int vikConstant = 199;
        static void Main(string[] args)
        {
            // Create a variable using the keyword “var.”
            var vikVariable = "Hallo zussammen!";

            // Chain two constructors together
            vikClass vikObj = new vikClass("A modern ape");

            // Test print these creations to console
            Console.WriteLine("The constant value: " + vikConstant);
            Console.WriteLine("The variable value: " + vikVariable);
            Console.WriteLine("The object name: " + vikObj.Bezeichnung);

            // Give user chance to read output
            Console.ReadLine();
        }
    }
}