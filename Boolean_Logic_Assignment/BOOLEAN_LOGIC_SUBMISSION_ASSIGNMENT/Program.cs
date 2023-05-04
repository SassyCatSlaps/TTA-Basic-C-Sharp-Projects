using System;

namespace BOOLEAN_LOGIC_SUBMISSION_ASSIGNMENT


    /*-----------------------------------------------------------------------------------

    ASSIGNMENT REQUIREMENTS 

    1. App must ask 3 questions:
        a. What is your age?  //  b. Have you ever had a DUI?  //  c. How many speeding tickets do you have?
    2. Use the following qualification rules to determine if the applicant qualifies for car insurance:
        a. Applicants must be over 15 years old  // b. Applicants must not have any DUI’s //  c. Applicants must not have more than 3 speeding tickets
    3. Print result of boolean expression created from the above business rules

        OUTPUT EXAMPLE:

            What is your age?
            32
            Have you ever had a DUI?
            false
            How many speeding tickets do you have?
            1
            Qualified?
            true
            
    -----------------------------------------------------------------------------------*/

{
    class Program
    {
        static void Main(string[] args)
        {
            //  a. What is your age?  //  b. Have you ever had a DUI?  //  c. How many speeding tickets do you have?
            // notice I am using conversions on the readline string to make it into an integer that I can later perform operations on
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Input either \'true\' or \'false\'");
            string userDUIinput = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int userSpdTicketCount = Convert.ToInt32(Console.ReadLine());

            // qualification rules: a. Applicants must be over 15 years old  // b. Applicants must not have any DUI’s //  c. Applicants must not have more than 3 speeding tickets
            // perform boolean comparisons to get final answer for if the user is qualified for car insurance
            // converted the DUIinput from a string to a boolean so that it could then be compared
            // this asks: is userAge greater than 15 AND is their DUIinput equal to false ('false' meaning they dont have a dui) AND is SpdTicketCount less than or equal to 3?

            bool QualificationStatus = userAge > 15 && (Convert.ToBoolean(userDUIinput) == false) && userSpdTicketCount <= 3;
            Console.WriteLine("Qualified?\n" + QualificationStatus);
            Console.ReadLine();
        }
    }
}
