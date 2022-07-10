using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //All console inputs are str type, so they have to be converted to the appropriate data type
            
            Console.WriteLine("Hello. Please enter a number you want to multiply by 50."); //getting input
            string num1 = Console.ReadLine(); //storing input as str var
            double dblNum1 = Convert.ToDouble(num1); //changing to a dbl var b/c the product might be large
            double timesFifty = dblNum1 * 50.0; //the operation
            Console.WriteLine(num1 + " times 50 = " + timesFifty); //returning the result to the console

            Console.WriteLine("Enter a number to add to 25.");
            string num2 = Console.ReadLine();
            int num2Cast = Convert.ToInt32(num2);
            int addTwentyFive = num2Cast + 25;
            Console.WriteLine(num2 + " plus 25 = " + addTwentyFive);

            Console.WriteLine("Enter a number to divide by 12.5.");
            string num3 = Console.ReadLine();
            double num3Cast = Convert.ToDouble(num3); //dbl var instead of int b/c of the potential for a long line of decimal places
            double quotTwelvePointFive = num3Cast / 12.5;
            Console.WriteLine(num3 + " divided by 12.5 = " + quotTwelvePointFive);

            Console.WriteLine("Enter a number to see if it is greater than 50.");
            string num4 = Console.ReadLine();
            int num4Cast = Convert.ToInt32(num4); //bool operation needs an int to compare to 50
            bool greaterThatFifty = num4Cast > 50; //with int var in place comparison proceeds
            Console.WriteLine(num4 + " is greater that 50 is " + greaterThatFifty);

            Console.WriteLine("Enter a number to divide by 7 and see if there is a remainder.");
            string num5 = Console.ReadLine();
            int num5Cast = Convert.ToInt32(num5); //convert before the operation
            int remainder = num5Cast % 7;
            Console.WriteLine(num5 + " divided by 7 leaves a remainder of " + remainder);

            Console.ReadLine();
        }
    }
}
