using System;
using System.Collections.Generic;
using System.Linq;

namespace PRACTICAL_EXAMPLE_USING_LINQ
{
    class Program
    {
        static void Main()
        {
            // Specify the data source
            string[] students = new string[] { "Bob", "Bobert", "Bobette", "Bobby", "Bobsie", "Bobser" };

            // Define the query expression
            IEnumerable<string> studentQuery =
                from student in students
                where student.Length >= 6
                select student;

            // Execute the query
            foreach (string s in studentQuery)
            {
                Console.WriteLine(s + " ");
            }
            Console.ReadLine();
        }
/* In this code, first note that I am using System.Linq.
The System.Linq namespace provides classes and interfaces that support queries that use LINQ.
Next, my data source is created.
The string array “students” is the data source that we will use LINQ to query. 
Since LINQ will return results as an object, the query must be stored in a variable that the object canbe returned to. 
In the example above, the query is saved to the variable “studentQuery.” 
The query syntax is stored inside of that variable.
The next step is to execute the LINQ query. 
For this example I am executing the query through a foreach loop. */
    }
}
