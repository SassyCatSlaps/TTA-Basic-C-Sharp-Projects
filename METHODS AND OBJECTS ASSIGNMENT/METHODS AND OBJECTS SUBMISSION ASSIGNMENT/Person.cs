using System;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create a void method called SayName that writes the person's full name to the console
        public void SayName()
        {
            // Here, I am practicing using ' $ ' and ' {} ' to make my code look nicer to read
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
    // Create a class called Employee that inherits from Person and has an integer property called 'Id'
    public class Employee : Person
    {
        public int Id { get; set; }
    }
}
