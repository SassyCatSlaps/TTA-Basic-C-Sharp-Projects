using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


/* System.Collections 
    - a namespace that contains interfaces and classes that define various collections of objects 
(such as lists, arrays, dictionaries, etc.). 
Collections are specialized classes that store a series of values or objects.

System.Collections.Generic 
    - a namespace with set of instructions that tells the comp to use a specific part of the BaseClassLibrary 
called System.Collections.Generic. The “dot” between each name could just as easily be an arrow denoting that one section is a subset of another
(i.e., System → Collections → Generic).
The System.Collections.Generic namespace contains classes and interfaces that allow developers to create strongly-typed
collections which provide better type safety and performance than non-generic collections.

using System.Linq 
    - a reference to another part of the BaseClassLibrary that deals w/ querying sets of information 
    (similar idea to the SQL query, but with more condensed terminology). LINQ stands for “Language-Integrated-Query.”

using System.Text
    - an instruction that says to use a part of the Base Class Library called System.Text, which enables easy ways to manipulate text.

using System.Threading.Tasks
    - a reference to a section of the BaseClassLibrary called System.Threading.Tasks. This provides easy support for doing 
    “multi-threaded” activities – which just means making a CPU do more than one thing at a time.
*/

// 'namespace' = added layer of organization for your code - it is listed above class.
// class = organized grouping of code which can also be used to define very specific ways that data works together.
// Namespaces make it easier to remember where items are stored.

// 'class Program' = the Program class is the main class in a console application.
// The comp searches for this class, then for the Main method as the place to start the application.

// 'static void Main(string[] args)':
// function named 'Main' that takes an argument named 'args'  ||  'string[]' = argument 'string array' (array = []) data type
// open/closed square brackets denote an array - (when subprog used/called the data passes to it = 'arguments')
// Console.WriteLine() = part of the System Library
// Console.ReadLine() = takes input from the screen/user
// the line after that is the automatic computer response to the input typed after user hits enter
// Console.Read(); will prevent the console window from closing until the user/dev has manually closed it - makes the console read then display the input


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Tell me your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Hallo, " + name + "!");
            Console.Read();
        }
    }
}
