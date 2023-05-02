using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Practice
{
    class Program
    {
        static void Main()
        {
            //strongly-typed = means you must describe what kind of variable you're creating (i.e. the data type) before stating its given name
            string firstName = "Vikko";
            string lastName = " FLS";
            int favoriteNumber = 100;

            string fullName = firstName + lastName;
            Console.WriteLine("Your name is " + fullName + " and your favorite number is " + favoriteNumber);
            Console.ReadLine();
        }
    }
}
