using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS_ASSIGNMENT_SUBMISSION
{
    // Create an Employee class with Id, FirstName and LastName properties  --  I put FirstName and LastName into a 'Person' class and had the Employee class inherit it
    public class Employee : Person
    {
        public int Id { get; set; }

        // In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
        public static bool operator== (Employee employee01, Employee employee02)
        {
            if (employee01.Id == employee02.Id)
                return true;
            else
            return employee01.Id == employee02.Id;
        }
        // Comparison operators must be overloaded in pairs
        public static bool operator!= (Employee employee01, Employee employee02)
        {
            return employee01.Id != employee02.Id;
        }
        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;
            return Id.Equals(emp.Id);
        }
    }
}
