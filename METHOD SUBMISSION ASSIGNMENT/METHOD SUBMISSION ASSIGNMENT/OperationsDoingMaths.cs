using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_SUBMISSION_ASSIGNMENT
{
    public class OperationsDoingMaths
    {
        // Method takes two integers (one of which is optional) then returns an integer result
        public int DoSomeMathOperation(int Num1, int Num2 = 0)
        {
            // Perform a maths operation based on the input parameters then return the result
            return Num1 * Num2;
        }
    }
}
