using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int inputConverted = Convert.ToInt32(Console.ReadLine()); //storing input as int var
            //declaring variables and setting to 0
            int sum = 0;
            int difference = 0;
            int product = 0;
            int quotient = 0;
            //calling methods from UserNumber class with converted user input as passed arg
            //storing in sum var
            sum = UserNumber.PlusOne(inputConverted);
            Console.WriteLine(inputConverted + " plus 1 equalts: " + sum); //writing result to console
            //storing in difference var
            difference = UserNumber.MinusOne(inputConverted);
            Console.WriteLine(inputConverted + " minus 1 equals: " + difference);
            //storing in product var
            product = UserNumber.TimesTwo(inputConverted);
            Console.WriteLine(inputConverted + " times 2 equals: " + product);
            //storing in quotient var
            quotient = UserNumber.DivideBy(inputConverted);
            Console.WriteLine(inputConverted + " divided by 2 equals: " + quotient);
            
            Console.ReadLine(); //pausing console

        }
    }
}
