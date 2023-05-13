using System;

// ABSTRACT CLASS ASSIGNMENT

// Perform these actions and create a console app that includes the following:
// Create an abstract class called Person with two properties: string firstName and string lastName.
// Give it the method SayName().
// Create another class called Employee and have it inherit from the Person class.
// Implement the SayName() method inside of the Employee class.
// Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
// Call the SayName() method on the object.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inside the Main() method instantiate an Employee object w/ firstName “Sample” and lastName “Student”
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // Call the SayName() method on the object
            employee.SayName();

            // Moment to read console output -- "Name: Sample Student"
            Console.ReadLine();
        }
    }
}
