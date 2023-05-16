using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfStructSyntax
{
    class Program
    {
        // Example code below shows how you would define an Employee structure:
        struct Employee
        {
            public int empId;
            public string firstName;
            public string lastName;
            public string ssn;
        }
        static void Main(string[] args)
        {
            // The following code shows how you would create an instance of the struct:

            // Declare emp1 of type 'Employee'
            Employee emp1;

            // emp1 specification
            emp1.empId = 666;
            emp1.firstName = "Cruella";
            emp1.lastName = "De Vil";
            emp1.ssn = "000-00-0000";
        }
    }
}
