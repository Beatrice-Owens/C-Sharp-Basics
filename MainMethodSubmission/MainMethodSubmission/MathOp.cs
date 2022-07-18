using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    public class MathOp
    {
        public static int PlusOne(int num1) //public method PlusOne takes int arg from user input in Program.cs
        {
            int sum = num1 + 1; //simple operation
            return sum; //return the int sum as output from method
        }

        public static int PlusOne(decimal num1) //set to take decimal arg as num1 var
        {
            decimal sum = num1 + 1; //operation
            int sumToInt = Convert.ToInt32(sum); //cast output to int as assigned
            return sumToInt; //return int var
        }

        public static int PlusOne(string num1) //set to take string var num1
        {
            int sumToInt3 = Convert.ToInt32(num1) + 1; //converting the arg to int in order to do math
            return sumToInt3; //returns int var result
        }
    }
}
