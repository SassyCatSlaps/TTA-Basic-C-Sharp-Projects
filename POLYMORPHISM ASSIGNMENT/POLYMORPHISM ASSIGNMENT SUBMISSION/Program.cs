using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// POLYMORPHISM ASSIGNMENT

// Perform these actions and create a console app that includes the following:
// Create an interface called IQuittable and have it define a void method called Quit().
// Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
// Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
// Hint: an object can be of an interface type if it implements that specific interface.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace POLYMORPHISM_ASSIGNMENT_SUBMISSION
{
    // NEW CODE:
    // Create an interface called IQuittable & have it define a void method called Quit()
    interface IQuittable
    {
        void Quit();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Code from previous 'ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT'
            // Inside the Main() method instantiate an Employee object w/ firstName “Sample” and lastName “Student”
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };
            // Call the SayName() method on the object
            employee.SayName();

            // NEW CODE:
            // Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable quittableEmployee = new Employee();

            // Call the Quit() method on the IQuittable object
            quittableEmployee.Quit();

            // Moment to read console output -- ' Name: Sample Student \n Quit your job! '
            Console.ReadLine();
        }
    }
}
