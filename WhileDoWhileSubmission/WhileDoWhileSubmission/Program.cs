using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhileSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess how old my cat is. Pick a number please."); //intro 
            int number = Convert.ToInt32(Console.ReadLine()); //making the guess an int var so it can be compared to 12 in the bool age var
            bool age = number == 12; //comparison expression that returns true/false based on whether number var is 12

            do //do this loop once first b4 entering the while loop, in case guess is correct first time
            {
                switch (number)
                {
                    case 1: //if they guess 1: 
                        Console.WriteLine("You guessed 1 year old. He's older than that. Try again."); //feedback based on the user input
                        Console.WriteLine("Guess a number."); //guess again
                        number = Convert.ToInt32(Console.ReadLine()); //reassigning the number int for a new guess
                        break; 
                    case 4:
                        Console.WriteLine("You guessed 4 years old. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9 years old. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 14:
                        Console.WriteLine("You guessed 14 years old. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12 years old. And you're right.");
                        age = true; //changes var to true to stop the while loop
                        break;
                    default:
                        Console.WriteLine("That's not quite right. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!age); //while age is false/not true, continue the loop

            Console.ReadLine(); //don't immediately close the console when the correct guess is finally made
        }
    }
}
