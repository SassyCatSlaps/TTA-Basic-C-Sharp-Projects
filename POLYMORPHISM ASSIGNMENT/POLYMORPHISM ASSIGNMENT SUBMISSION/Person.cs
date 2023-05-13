using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM_ASSIGNMENT_SUBMISSION
{
    // Code from previous 'ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT'
    // Create an abstract class called Person with two properties: string firstName and string lastName
    public abstract class Person
    {
        public string firstName;
        public string lastName;

        // Give it the method SayName().
        public abstract void SayName();
    }

    // NEW CODE:
    // Create another class called Employee and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
        // Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // NEW CODE:
        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Quit your job!");
        }
    }
}

