using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //list creation & set bool var to false to prevent false positives after try block
            List<int> numbers = new List<int>() { 10, 15, 20, 25, 30 };
            bool operationSuccess = false;
            
            try
            {
                //enter input & convert it to an int var
                Console.WriteLine("Enter a number.");
                int divisorInput = Convert.ToInt32(Console.ReadLine());

                //cycle through each value at the given index
                for (int i = 0; i < numbers.Count; i++)
                {
                    //int var for quotient of operation between value at index [i] and user input
                    int quotient = numbers[i] / divisorInput;
                    Console.WriteLine(numbers[i] + " divided by " + divisorInput + " equals " + quotient); //results
                    operationSuccess = true; //change bool to true to let user know later try block success
                }
            }
            catch (FormatException ex) //if incompatible input with int:
            {
                Console.WriteLine(ex.Message); //error message displayed
            }
            catch (DivideByZeroException ex) //if input is 0:
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) //other errors/exceptions
            {
                Console.WriteLine(ex.Message);
            }
            /*finally //make sure the app pauses
            {
                Console.ReadLine();
            }*/

            if (operationSuccess == true) //let us know if try block succeeded:
            {
                Console.WriteLine("\nWe made it through.");
            }
            else //if it didn't succeed:
            {
                Console.WriteLine("\nThere was an error. We didn't make it through.");
            }
            Console.ReadLine();
            
        }
    }
}
