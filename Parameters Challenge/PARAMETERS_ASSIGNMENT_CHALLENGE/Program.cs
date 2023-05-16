using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PARAMETERS CHALLENGE

// Perform these actions and create a console app that includes the following:
// Make the Employee class take a generic type parameter.
// Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.
// Instantiate an Employee object with type “string” as its generic parameter.
// Assign a list of strings as the property value of Things.
// Instantiate an Employee object with type “int” as its generic parameter.
// Assign a list of integers as the property value of Things.
// Create a loop that prints all of the Things to the Console.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


namespace PARAMETERS_ASSIGNMENT_CHALLENGE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type “string” as its generic parameter
            Employee<string> employeeStrg = new Employee<string>();

            // Assign a list of strings as the property value of Things
            employeeStrg.Things = new List<string> { "buff", "lil", "baby", "shake", "fanny" };

            // Instantiate an Employee object with type “int” as its generic parameter
            Employee<int> employeeInt = new Employee<int>();

            // Assign a list of integers as the property value of Things
            employeeInt.Things = new List<int> { 10, 20, 30, 40, 50 };

            // Create a loop that prints all of the Things to the Console  --  hoping this is an ok way to do my loop
            foreach (string item in employeeStrg.Things)
            {
                Console.WriteLine(item);
            }
            foreach (int item in employeeInt.Things)
            {
                Console.WriteLine(item);
            }
            // Give user chance to read output before closing console window
            Console.ReadLine();
        }
    }
}
