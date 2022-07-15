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
            string[] pairs = { "ab", "cd", "ef", "gh" };
            Console.WriteLine("Enter some text to add to each element in our string.");
            string addToEachStr = Console.ReadLine(); //the input to be added

            for (int i = 0; i < pairs.Length; i++) //cycles through each entry in array
            {
                pairs[i] = pairs[i] + addToEachStr; //add the input to each entry one by one
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
            
            //Part 4: List w/unique entries; user searches for entries and is told its index or if it doesn't exist
            List<string> hanQuote = new List<string>() { "i", "got", "a", "bad", "feeling", "about", "this" };
            Console.WriteLine("Please enter some text you would like to search for in this list.");
            string hanListGuess = Console.ReadLine().ToLower();
            bool hanGuessPresent = false;

            for (int i = 0; i < hanQuote.Count; i++) //cycling through the list entries
            {
                if (hanListGuess == hanQuote[i]) //if the guess = the entry, then: 
                {
                    hanGuessPresent = true; //change bool to true to stop further loops
                    Console.WriteLine(i); //write the index of the entry
                    break; //stop this if statement from needlessly searching through every other entry in the list
                }
            }
            if (hanGuessPresent == false) //if the guess isn't in the list:
            {
                Console.WriteLine("Sorry. Your input isn't on the list.");
                
            }
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            
            //Part 5: List with duplicates; search for items based on values; display indices of all related
            List<string> dna = new List<string>() { "A", "T", "C", "G", "A", "T", "T", "G", "A", "G", "C", "T" };
            Console.WriteLine("Please enter a protein initial to search for.");
            string searchDNAEntry = Console.ReadLine().ToUpper(); //force uppercase
            bool presentDNA = false;

            for (int p = 0; p < dna.Count; p++)
            {
                if (searchDNAEntry == dna[p])
                {
                    presentDNA = true;
                    Console.WriteLine(p); 
                    //no break statement this time because there could be duplicate entries
                }
            }
            if (presentDNA == false)
            {
                Console.WriteLine("Sorry. Your input isn't on the list.");

            }
            Console.WriteLine("Press Enter.");
            Console.ReadLine();
            

            //Part 6: str list with some identical elements; loop through a list unique vs. duplicate
            List<string> favColors = new List<string>() { "yellow", "blue", "red", "green", "yellow", "orange", "blue", "pink", "purple", "blue" };
            List<string> dupColors = new List<string>(); //second list creted to hold unique entries from favColors
            //and compare them 

            foreach (string color in favColors) //do this for each entry in the list
            {
                if (dupColors.Contains(color)) //used the .Contains() method to check if color has been placed in dupcolors
                {
                    Console.WriteLine(color + " - this item is a duplicate."); //if it is in dupColors, it is a duplicate
                }
                else //entries not already present in dupColors
                {
                    Console.WriteLine(color + " - this item is unique."); //they aren't there yet = they are unique
                    dupColors.Add(color); //after identifying them, colors are moved to dupColors to compare to other entries
                }
                //no need to break since we need to exhaust all entries in the list
            }
            Console.WriteLine("\nThe End"); //the end
            Console.ReadLine();
        }
    }
}
