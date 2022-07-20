using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalAgumentAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int number1 = Convert.ToInt32(Console.ReadLine()); //casting input to int var for math
            Console.WriteLine("You may choose to enter a second number now. If you don't want to, just press Enter.");
            int number2; //inst. second int var for optional param
            //checks if the input can be cast as int and sends it out as int, sends it out as number2 if possible
            //also needed for following if/else statements
            bool success = int.TryParse(Console.ReadLine(), out number2); 

            int sum = 0; //inst. int var "sum" to receive returned int from method PlusSome()

            //if the bool success is true, input the extra optional param
            //if not true, don't send the number2 var to the method, since it would cause errors
            if (success)
            {
                sum = MiniMath.PlusSome(number1, number2); //sends both
                Console.WriteLine("{0} plus {1} equals: {2}", number1, number2, sum); //output

            }
            else
            {
                sum = MiniMath.PlusSome(number1); //sends necessary param
                Console.WriteLine("{0} plus 1 equals: {1}", number1, sum);

            }
            Console.ReadLine(); //pause for readability
            

        }
    }
}
