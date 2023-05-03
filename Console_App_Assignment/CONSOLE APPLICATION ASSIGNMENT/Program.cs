using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APPLICATION_ASSIGNMENT
{
    class Program
    {
        static void Main()
        {
            //Take input from the user, multiply by 50, then print result to the console
            //you see I took a string input and converted it to an integer and then assigned that conversion value to 'Num1'
            Console.WriteLine("Please type a number and then press enter. Press enter after result is printed to continue.");
            string input1 = Console.ReadLine();
            int Num1 = Convert.ToInt32(input1);
            int Result1 = Num1 * 50;
            Console.WriteLine("Input multiplied by fifty is: " + Result1);
            Console.ReadLine();

            //Take input from user, add 25 to it, then print result to console
            Console.WriteLine("Please enter another number");
            string input2 = Console.ReadLine();
            int Num2 = Convert.ToInt32(input2);
            int Result2 = Num1 + 25;
            Console.WriteLine("Input added to twenty-five is: " + Result2);
            Console.ReadLine();

            //Take input from user, divide it by 12.5, then print result to console
            Console.WriteLine("Please enter another number.");
            string input3 = Console.ReadLine();
            double Result3 = Convert.ToDouble(input3) / 12.5;
            Console.WriteLine("Result of user input divided by 12.5 is: " + Result3);
            Console.ReadLine();

            //Take user input, check if greaterthan '>' 50, then print true/false result to console
            //this time the input4 must be of data type 'int' to avoid having to parse
            //I can convert the user input string i.e 'Console.ReadLine()' into an integer using 'Convert.ToInt32' so that it can be compared to the integer 50
            Console.WriteLine("Please enter another number");
            int input4 = Convert.ToInt32(Console.ReadLine());
            bool Result4 = input4 > 50;
            Console.WriteLine("Is user input greater than 50: " + Result4);
            Console.ReadLine();

            //Take input from user, divide by 7, then print remainder to console
            Console.WriteLine("Please enter another number");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int remainder = input5 % 7;
            Console.WriteLine("Remainder result of user input divided by seven is: " + remainder);
            Console.ReadLine();
        }
    }
}
