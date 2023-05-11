using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_ASSIGNMENT_SUBMISSION
{
    // made sure to make Maths class public so I could call on its innards in my Main Program file
    public class Maths
    {
        // In that class, create three methods, each of which will take one integer parameter in and return an integer:
        // The methods should do some math operation on the received parameter.
        // Put this class in a separate.cs file in the application
        

        // First Method:
        public static int MultByFive(int userInput)
        {
            int result = userInput * 5;
            return result;
        }
        // Second Method:
        public static int AddSixteen(int userInput)
        {
            int result = userInput + 16;
            return result;
        }
        // Third Method:
        public static int SubTen(int userInput)
        {
            int result = userInput - 10;
            return result;
        }
        // hope I understood this right @_@;
    }
}
