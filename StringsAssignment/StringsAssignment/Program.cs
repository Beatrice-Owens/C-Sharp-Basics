using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make a basic sentence that might make us sound like cavemen."); //intro
            Console.WriteLine("Please enter a noun subject."); //getting input
            string noun = Console.ReadLine(); //creating str var
            Console.WriteLine("Please enter a transitive verb.");
            string verb = Console.ReadLine();
            verb = verb.ToUpper(); //all uppercae for task 2: "Converts a string to uppercase."
            Console.WriteLine("Please enter a direct object.");
            string directObject = Console.ReadLine();
            //concat 3 str var, capitalizing the first letter of noun var, adding spaces and a period
            Console.WriteLine(char.ToUpper(noun[0]) + noun.Substring(1)+ " " + verb + " " + directObject + ".");
            Console.WriteLine("Please press \"enter.\""); //to get to the next section

            Console.ReadLine(); //pause b4 moving on

            Console.WriteLine("Now, let's write a little five-sentence story."); //intro
            Console.WriteLine("Please enter the first sentence of your story."); //enter a full sentence
            StringBuilder story = new StringBuilder(Console.ReadLine()); //creating a new SB using the input ^^
            Console.WriteLine("Enter the second sentence of your story."); //getting more input
            story.AppendLine().Append(Console.ReadLine()); //adding a sentence onto the SB one line below the first
            Console.WriteLine("Enter the third sentence of your story.");
            story.AppendLine().Append(Console.ReadLine()); //adding another sentence a line below the previous
            Console.WriteLine("Enter the fourth sentence of your story.");
            story.AppendLine().Append(Console.ReadLine()); //down and add
            Console.WriteLine("Enter the fifth and final sentence of your story.");
            story.AppendLine().Append(Console.ReadLine()); //down and add

            Console.WriteLine("Here is your story:"); //presentation
            Console.WriteLine(story); //displaying the story in full
            Console.ReadLine(); //don't immediately close
        }
    }
}
