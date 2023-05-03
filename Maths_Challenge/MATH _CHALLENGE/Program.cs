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

            //Lets add some different data types  ||  I will assign the result to the most specific data type being used
            //the most specific data type in this instance is going to be 'float' b/c it can have decimal places
            //if I needed 'Total' to be type 'int' then I would need to cast numF to int before performing calculation
            //i.e. - int total = numI + (Int32)numF;  || when casting down, the nums after the decimal point will be lost aka "rounded down"
            int numI = 7;
            float numF = 5.5f;

            float Total = numI + numF;
            Console.WriteLine(Total);
            Console.ReadLine();

            //lets try adding a float and a double  ||  b/c double allows for #s to be 15-16 long vs float's 7 digit limit, it is the more precise choice
            //when the compiler converts float to a double w/o being told to = an "implicit conversion"
            double num9 = 7.03230923;
            float num10 = 5.9f;
            double newTotal = num9 + num10;
            Console.WriteLine(newTotal);
            Console.ReadLine();

            //inversly, to convert a double to a float, I must do an "explicit conversion" on the double value like so:
            double Num9 = 7.03230923;
            float Num10 = 5.9f;
            float NewTotal = (float)Num9 + Num10;
            Console.WriteLine(NewTotal);
            Console.ReadLine();

            //there is no implicit conversion for float or double to a 'decimal' and thus must be done "explicityly" || encoded diff than other # data types
            //implicitly cast int to decimal:
            decimal Num1 = 7.03230923m;
            int Num2 = 5;
            decimal TOTAL = Num1 + Num2;
            Console.WriteLine(TOTAL);
            Console.ReadLine();

            //can create the same output with:
            decimal NumOne = 7.03230923m;
            sbyte NumTwo = 5;
            decimal newTOTAL = NumOne + NumTwo;
            Console.WriteLine(newTOTAL);
            Console.ReadLine();

            //maths with strings! aka "string concatenation"  || addition is the only maths operator available to strings
            string firstName = "Vikko";
            string lastName = "Ikko";
            Console.WriteLine(firstName + lastName);
            Console.ReadLine();

            //implicit conversion of data types:
            string NAME = "Vikko";
            int NUMBER = 10;
            Console.WriteLine(NAME + NUMBER);
            Console.ReadLine();
        }
    }
}
