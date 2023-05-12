using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    // Declare a class
    public class Mathmagical
    {
        // Declare a void method that outputs an integer
        public int divideByTwo(int Number)
        {
            return Number / 2;
        }

        // Declare a void method with output parameters
        public void divideByTwoWithOutput(int Number, out int Result)
        {
            Result = Number / 2;
        }

        // Overload the DivideByTwo method
        public int divideByTwo(int Number, int Divider)
        {
            return Number / Divider;
        }
    }
}
