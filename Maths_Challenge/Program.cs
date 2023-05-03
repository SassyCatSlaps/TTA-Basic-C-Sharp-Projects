using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATH__CHALLENGE
{
    class Program
    {
        static void Main(string[] args)
        {
            string pressEnter = "Please press 'enter' on your keyboard to cycle through maths answers";
            Console.WriteLine(pressEnter);
            Console.ReadLine();

            //Add two numbers and display the output in the console
            int num1 = 10;
            int num2 = 43;
            int total = num1 + num2;
            Console.WriteLine(total);
            Console.ReadLine();

            //Subtract two numbers and display the output in the console
            int num3 = 89;
            int num4 = 15;
            int difference = num3 - num4;
            Console.WriteLine(difference);
            Console.ReadLine();

            //Multiply two numbers and display the output in the console
            int num5 = 20;
            int num6 = 8;
            int product = num5 * num6;
            Console.WriteLine(product);
            Console.ReadLine();

            //Divide two numbers and display the output in the console
            int num7 = 102;
            int num8 = 4;
            int quotient = num7 / num8;
            Console.WriteLine(quotient);
            Console.ReadLine();
        }
    }
}
