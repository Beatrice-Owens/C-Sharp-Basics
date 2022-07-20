using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleNamedParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //inst. two int vars with values 
            int number1 = 2;
            int number2 = 3;
            
            //3. calling method a passing param two values
            IntegerIntake.MultiNum(number1, number2);

            //4. calling the method from class IntegerIntake and passing param by name
            IntegerIntake.MultiNum(num1: number1, num2: number2);
            //each way of calling the method should display the same value
            Console.ReadLine();//pause for readability
        }
    }
}
