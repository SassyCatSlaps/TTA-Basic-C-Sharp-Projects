using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create an anonymous income comparison program

// 1. program must start by printing “Anonymous Income Comparison Program” to screen
// 2. It must then print “Person 1” to the screen and get the following details from user input:
        // a. Hourly Rate  ||  b. Hours worked per-week
// 3. It must then print “Person 2” to the screen and then get the following details from user input:            
        // a. Hourly Rate  ||  b. Hours worked per-week
// 4. It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it
// 5. It must then print to screen “Annual salary of Person 2:” and display exact salary below it
// 6. It must then print to screen “Does Person 1 make more money than Person 2?” and write true or false value of this statement below it
/* --------------------------------------------------------

   PRINT EXAMPLE:
        Anonymous Income Comparison Program
        Person 1
        Hourly Rate?
        15
        Hours worked per week?
        40
        Person 2
        Hourly Rate?
        20
        Hours worked per week?
        40
        Annual salary of Person 1:
        31,200
        Annual salary of Person 2:
        41,600
        Does Person 1 make more money than Person 2?
        False 

-------------------------------------------------------------*/

namespace Maths_And_Comparison_Operator
{
    class Program
    {
        static void Main()
        {
            // 1. program must start by printing “Anonymous Income Comparison Program” to screen
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // 2. It must then print “Person 1” to the screen and get the following details from user input:  a. Hourly Rate  ||  b. Hours worked per-week
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            double HourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per-week?");
            double HrsWrkdPerWeek1 = Convert.ToDouble(Console.ReadLine());

            // 3. It must then print “Person 2” to the screen and then get the following details from user input: a. Hourly Rate  ||  b. Hours worked per-week
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly Rate?");
            double HourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per-week?");
            double HrsWrkdPerWeek2 = Convert.ToDouble(Console.ReadLine());

            // 4. It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it
            // Here I will do 2 multiplication operations in one ||  HourlyRate# * HrsWrkdPerWeek = weeklySalary * WeeksInYear  ||  do this once for each person
            // I have assigned the var WeeksInYear to 52 instead of just multiplying by 52 but either works here

            var WeeksInYear = 52;
            double AnnualSalary1 = HourlyRate1 * HrsWrkdPerWeek1 * WeeksInYear;
            double AnnualSalary2 = HourlyRate2 * HrsWrkdPerWeek2 * WeeksInYear;


            Console.WriteLine("\nAnnual salary of Person 1: " + AnnualSalary1);
            // 5. It must then print to screen “Annual salary of Person 2:” and display exact salary below it
            Console.WriteLine("\nAnnual salary of Person 2: " + AnnualSalary2);

            // 6. It must then print to screen “Does Person 1 make more money than Person 2?” and write true or false value of this statement below it
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool whoMakesMore = AnnualSalary1 > AnnualSalary2;
            Console.WriteLine(whoMakesMore);
            Console.ReadLine();
        }
    }
}
