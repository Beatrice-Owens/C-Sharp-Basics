using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 create a str array, take input and add to each element in array
            /*
            string[] pairs = { "ab", "cd", "ef", "gh" };

            Console.WriteLine("Enter some text to add to each element in our string.");
            string addToEachStr = Console.ReadLine();

            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = pairs[i] + addToEachStr;
            }

            for (int i = 0; i < pairs.Length; i++)
            {
                Console.WriteLine(pairs[i]);
            }
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            //Part 2 create an infinite loop then fix it
            bool stopLoop = true; //so it is easier to stop the loop
            while (stopLoop == true) //keeps going until stopLoop is "false"
            {
                Console.WriteLine("It never stops. Until it does."); //print this
                stopLoop = false; //changes the value of bool var to false, breaking the while loop
            }
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            
            //Part 3 loop using "<" operator; loop using "<=" operator
            Console.WriteLine("Enter a number to count to.");
            int endNum = Convert.ToInt32(Console.ReadLine());
            int firstNum = 1;

            while (firstNum < endNum +1) //using to "<" operator to count TO a number meant adding one to the input
            {
                Console.WriteLine(firstNum);
                firstNum++;
            }

            Console.WriteLine("\nEnter another number to count to.");
            int endNum2 = Convert.ToInt32(Console.ReadLine());
            int firstNum2 = 1;

            while (firstNum2 <= endNum2) //using "<=" operator to count to something didn't require augmentation
            {
                Console.WriteLine(firstNum2);
                firstNum2++;
            }
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            */
            /*
            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string name in names)
            {
                if (name == "Adam")
                {
                    int nameIndex = names.IndexOf(name);
                    Console.WriteLine(nameIndex);
                }

                //Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            List<string> hanQuote = new List<string>() { "i", "got", "a", "bad", "feeling", "about", "this" };
            Console.WriteLine("\nPlease enter some text you would like to search for in this list.");
            string hanListGuess = Console.ReadLine().ToLower();
            int hanListCount = hanQuote.Count;
            bool hanGuessPresent = false;


            while (hanGuessPresent == false)
            {
                foreach (string word in hanQuote)
                {
                    int hanIndex = hanQuote.IndexOf(word);
                    if (word == hanListGuess)
                    {
                        Console.WriteLine(String.Format("Your guess \"{0}\" is found at index {1}", word, hanIndex));
                        hanGuessPresent = true;
                    }
                    else if (hanIndex >= hanListCount)
                    {
                        Console.WriteLine("Sorry. Your input isn't on the list. Enter new text.");
                        hanListGuess = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        
                    }
                }
            }
            
            

            Console.ReadLine();
        }
    }
}
