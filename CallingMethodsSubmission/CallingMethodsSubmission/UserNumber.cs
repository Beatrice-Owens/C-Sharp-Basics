using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    //class UserNumber created to house math methods; public so it can be called in main Program.cs
    public class UserNumber
    {
        public static int PlusOne(int num1) //public method PlusOne takes int arg from user input in Program.cs
        {
            int sum = num1 + 1; //simple operation
            return sum; //return the sum as output from method
        }

        public static int MinusOne(int num1) //separate method for subtraction
        {
            int difference = num1 - 1; //given arg -1 stored in int var
            return difference; //return difference as output
        }

        public static int TimesTwo(int num1) //multiplication method
        {
            int product = num1 * 2; // arg * 2
            return product; //return product
        }

        public static int DivideBy(int num1) //division operation
        {
            int quotient = num1 / 2; //store arg / 2 in quotient
            return quotient; //return quotient
        }
    }
}
