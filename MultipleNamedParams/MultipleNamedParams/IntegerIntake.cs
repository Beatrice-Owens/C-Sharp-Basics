using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleNamedParams
{
    public class IntegerIntake
    {
        //create a void method (doesn't return a value) that takes two named arg
        public static void MultiNum(int num1, int num2)
        {
            //method must perform math operation on first integer
            int sum = num1 + 1;
            Console.WriteLine(num2); //method must simply display the second int
            return; 
        }
    }
}
