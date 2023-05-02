using System;

// can refer to namespace in another project if so desired
namespace DAILY_REPORT__ASSIGNMENT
{
    class Program
    {
        static void Main()
        {
            // prints basic greeting, purpose of program, and basic instruction on how to 'start' the program
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("\nStudent Daily Report");
            Console.WriteLine("\nPress \'ENTER\' to begin and to continue through each question after writing your answer.");
            Console.ReadLine();

            // following code blocks print text to console for user - it then takes in and then prints user inputs to console
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("Registered student name is: " + studentName);
            Console.ReadLine();

            // next two code blocks ask student what they're up to in their course work
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are currently studying the: " + courseName + " course");
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            Console.WriteLine("You are on: " + pageNum);
            Console.ReadLine();

            // the console cannot implicity convert .readline for a boolean - needs to be converted to a string
            // here I skipped using the 'ToString()' method and directly concatenated the boolean variable w/ string
            // by simply using the '+' operator and 'Convert.ToBoolean'
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.\"");
            bool helpAnswer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Help needed?: " + helpAnswer);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string studentXP = Console.ReadLine();
            Console.WriteLine("Your experiance today: " + studentXP);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string studentFB = Console.ReadLine();
            Console.WriteLine("Daily feedback: " + studentFB);
            Console.ReadLine();

            // used a string here so the student may enter a integer or a variable and avoided casting or parsing
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("Total hours studied: " + hoursStudied);
            Console.ReadLine();

            // sign off/thank you text that is printed to the console before the program ends
            Console.WriteLine("Thank you for your answers.\nAn Instructor will respond to this shortly.\nHave a great day!");
            Console.ReadLine();
        }
    }
}
