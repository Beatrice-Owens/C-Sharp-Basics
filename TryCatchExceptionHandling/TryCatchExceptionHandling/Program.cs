using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try block to test the code
            try
            {
                //set bool to false to enter while loop and test for correct input
                bool validInput = false;
                //instan. age int
                int age = 0;
                //while bool is false:
                while (!validInput)
                {
                    Console.WriteLine("Enter your age.");
                    //can input be converted to an int, out int value back to age if yes
                    validInput = int.TryParse(Console.ReadLine(), out age);
                    //if no int casting, print the message and accept new input
                    if (!validInput) Console.WriteLine("Please enter positive digits only, no decimals.");
                }
                //prevent age zero
                if (age == 0)
                {
                    //throw specifically created exception
                    throw new ZeroException();
                }
                //prevent negative age
                if (age < 0)
                {
                    //throw specifically created exception
                    throw new NegativeException();
                }
                //if not exceptions were triggered: convert age to negative
                //this allows the use of the .AddYears method with DateTime, simplifying things
                int ageNegative = age * -1;
                //write out year user was born
                Console.WriteLine("You were born in the year {0}.", DateTime.Now.AddYears(ageNegative).Year);
                Console.ReadLine();
            }
            //if this exception is found: message and end program
            catch (ZeroException)
            {
                Console.WriteLine("You must enter a non-zero number.");
                Console.ReadLine();
                return;
            }
            //if this exception is found: message and end program
            catch (NegativeException)
            {
                Console.WriteLine("You must enter a non-negative number.");
                Console.ReadLine();
                return;
            }
            //general exception
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your system administrator.");
                Console.ReadLine();
                return;
            }
        }
    }
}
