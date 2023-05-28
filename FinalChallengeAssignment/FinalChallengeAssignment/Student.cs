using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a basic Entity Framework Code-First console application that creates a basic Student database and adds one student
// Added a 'Student' class
// Added another class called 'StudentContext' (see logic added in file) -- similar to the 'BloggingContext' example found here:https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database

namespace FinalChallengeAssignment
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
