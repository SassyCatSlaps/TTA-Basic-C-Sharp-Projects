using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Perform these actions and create a console app that includes the following:
// Create an Employee class with Id, FirstName and LastName properties. 
// In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
// Remember that comparison operators must be overloaded in pairs.
// In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties.
// Then compare the two Employee objects using the newly overloaded operators and display the results.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace OPERATORS_ASSIGNMENT_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties
            Employee employee01 = new Employee();
            employee01.FirstName = "Vikko";
            employee01.LastName = "Vibes";
            employee01.Id = 0006;

            Employee employee02 = new Employee();
            employee02.FirstName = "Kharon";
            employee02.LastName = "Ferryman";
            employee02.Id = 666666;

            // Then compare the two Employee objects using the newly overloaded operators and display the results
            if (employee01 == employee02)
            {
                Console.WriteLine("These two employees have identical ID numbers.");
            }
            else
            {
                Console.WriteLine("These two employees have different ID numbers.");
            }
            // Moment for user to read output before closing program
            Console.ReadLine();
        }
    }
}
