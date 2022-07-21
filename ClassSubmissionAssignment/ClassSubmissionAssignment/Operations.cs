using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Operations
    {
        //1. create class with void method that outputs necessary input arg after dividing by 2
        public void DivisionOp(int num1)
        {
            int quotient = num1 / 2; //math op
            Console.WriteLine("{0} divided by 2 equals: {1}", num1, quotient); //write this after op
        }

        //4. Create method with output param
        //rather than have the method itself immediately do something with the result, 
        //output that data to a var in main program.cs to be used as needed and doesn't count as returning a value
        public void MultiplyOp(int num1, out int product)
        {
            product = num1 * 2;
        }
    }
}
