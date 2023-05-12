using System;

// METHODS AND OBJECTS SUBMISSION ASSIGNMENT

// Perform these actions and create a console app that includes the following:
// Create a class called Person and give it two properties, each of data type string.
// One called FirstName, the other LastName.
// Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: “Name: [full name]”.
// Create another class called Employee and have it inherit from the Person class.
// Give the Employee class a property called Id and have it be of data type int.
// Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.
// Call the superclass method SayName() on the Employee object.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object w/ a first name of "Sample" and a last name of "Student"
            var employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };
            // Call the superclass method SayName on the Employee object
            employee.SayName();

            // Give user time to see output before closing window - will just output "Name: Sample Student"
            Console.ReadLine();
        }
    }
}
