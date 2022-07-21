using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. user enters a number, convert it to int for math, create int var to hold output of MultiplyOp()
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int multiplyOutput;

            //2. Instan. a class, call method on number input by user, display result
            Operations operations = new Operations(); 
            operations.DivisionOp(num1);
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine(); //pause
            
            //4. method with output param, takes previous input
            operations.MultiplyOp(num1, out multiplyOutput);
            Console.WriteLine("{0} times 2 equals: {1}", num1, multiplyOutput);
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            //option to enter another number for overloaded class, create int var to hold possible input
            //checks if the input can be cast as int and sends it out as int, sends it out as num2 if possible
            //also needed for following if/else statements
            Console.WriteLine("You may choose to enter a second number now. If you don't want to, just press Enter.");
            int num2; 
            bool success = int.TryParse(Console.ReadLine(), out num2);
            int areaResult; //inst. var to receive int from Area()

            //if the bool success is true, input the extra optional param
            //if not true, don't send the num2 var to the method, since it would cause errors
            if (success)
            {
                areaResult = Overload.Area(num1, num2); //sends both
                Console.WriteLine("The area of a rectangle with length {0} and width {1} equals: {2}", num1, num2, areaResult); //output

            }
            else
            {
                areaResult = Overload.Area(num1); //sends necessary param
                Console.WriteLine("The area of a square with length {0} equals: {1}", num1, areaResult);

            }
            Console.ReadLine(); //pause for readability

        }
    }
}
