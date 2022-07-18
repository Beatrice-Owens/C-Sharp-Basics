using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes in user number & convert to int var
            Console.WriteLine("Please enter a number.");
            int numberIntCast = Convert.ToInt32(Console.ReadLine());

            //inst. the sum var used to hold results of next method
            int sum = 0;

            sum = MathOp.PlusOne(numberIntCast); //the method called from class MathOp with int arg
            Console.WriteLine("{0} plus 1 equalts: {1}", numberIntCast, sum); //published results
            Console.WriteLine("Press Enter to continue."); //cont.
            Console.ReadLine();

            //take in user numb & convert to decimal 
            Console.WriteLine("Please enter a decimal number.");
            decimal numDecimal = Convert.ToDecimal(Console.ReadLine());

            //inst. the sum2 var as int since the next method returns an int, not decimal var
            int sum2 = 0;

            sum2 = MathOp.PlusOne(numDecimal); //method PlusOne with decimal arg
            Console.WriteLine("{0} plus 1 equals {1} when converted from deciaml to integer.", numDecimal, sum2);
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            //keeping input as string since next method requires str arg
            Console.WriteLine("Please enter another whole number.");
            string userNumberStr = Console.ReadLine();

            //inst. sum3 as int var since next method returns int not string var
            int sum3 = 0;

            sum3 = MathOp.PlusOne(userNumberStr); //method PlusOne with str var arg
            Console.WriteLine("{0} plus 1 equals {1}.", userNumberStr, sum3); //result
            Console.WriteLine("Press Enter to complete the app.");

            Console.ReadLine();
        }
    }
}
