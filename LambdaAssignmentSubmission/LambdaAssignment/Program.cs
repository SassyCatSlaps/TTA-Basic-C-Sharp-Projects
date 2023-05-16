using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Perform these actions and create a console app that includes the following:
// Create an Employee class with the following properties:
// a.Id // b.First Name // c. Last Name //  
// In the Main() method, create a list of at least 10 employees.
// Using a foreach loop, create a new list of all employees with the first name “Joe”.
// In your comparison statement, remember to reference the property of the object you are checking.
// Perform the same action again, but this time with a lambda expression.
// Using a lambda expression, make a list of all employees with an Id number greater than 5.
// Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, create a list of at least 10 employees
            List<Employee> employees = new List<Employee>
            {
                // At least two employees should have the first name “Joe”
                new Employee { ID = 1, FirstName = "Avrum", LastName = "Levi" },
                new Employee { ID = 2, FirstName = "Sara", LastName = "Rezae" },
                new Employee { ID = 3, FirstName = "Joe", LastName = "Esfahani" },
                new Employee { ID = 4, FirstName = "Shimon", LastName = "Weiss" },
                new Employee { ID = 5, FirstName = "Yosef", LastName = "Adler" },
                new Employee { ID = 6, FirstName = "Devorah", LastName = "Gershon" },
                new Employee { ID = 7, FirstName = "Rivka", LastName = "Schwartz" },
                new Employee { ID = 8, FirstName = "Joe", LastName = "Rahimi" },
                new Employee { ID = 9, FirstName = "Chaya", LastName = "Ahmad" },
                new Employee { ID = 10, FirstName = "Neda", LastName = "Levine" }
            };

            // Using a foreach loop, create a new list of all employees with the first name “Joe”
            // In your comparison statement, remember to reference the property of the object you are checking
            List<Employee> OnlyJoes = new List<Employee>(); // list for all the Joes
            foreach (Employee employee in employees) // foreach loop
            {
                if (employee.FirstName == "Joe")
                {
                    OnlyJoes.Add(employee);
                }
            } 

            // Perform the same action again, but this time with a lambda expression -- i.e. Using a lambda expression, create a new list of all employees with the first name "Joe"
            List<Employee> LambdaOnlyJoes = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Created a print statement to check if Lambda expression is working properly
            Console.WriteLine("These employees all have the first name Joe: \n");
            foreach (Employee uniqueJoe in LambdaOnlyJoes)
            {
                Console.WriteLine($"Name: {uniqueJoe.FirstName} {uniqueJoe.LastName} | ID: {uniqueJoe.ID}");
            }

            // Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> LambdaIdMoreThanFive = employees.Where(employee => employee.ID > 5).ToList();

            // Made another print statement to check if Lambda expression is working properly
            Console.WriteLine("\nThese employees have ID numbers that are greater than five: \n");
            foreach (Employee employee in LambdaIdMoreThanFive)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " | ID: " + employee.ID);
            }
            // Allow user to read output
            Console.ReadLine();
        }
    }
}
