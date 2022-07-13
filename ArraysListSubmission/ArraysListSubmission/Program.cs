using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //create and define a string array
        string[] strArray = { "these", "aren't", "the", "droids", "you're", "looking", "for" };
        
        Console.WriteLine("Please select an index number to learn more about this string array."); //get info
        int strIndexGuess = Convert.ToInt32(Console.ReadLine()); //cast input into int var for comparison purposes
        bool strIndexBool = strIndexGuess < 7 && strIndexGuess > 0; //don't know the shorthand for this: true if input is 0-6

        do //to check for applicable results b4 the while loop kicks in
        {
            //nested if/else if/else statements to check for relevant data, and
            //if none is found, restart the sequence with appropriate data
            if (strIndexGuess > 6) //over 6 is over the indices possible for this array
            {
                Console.WriteLine("Oops. Please select an index between 0 and 6."); //user didn't guess in proper param
                strIndexGuess = Convert.ToInt32(Console.ReadLine()); //reassigning index input var with new info
            }
            else if (strIndexGuess < 0) //under 0 is below lowest index in the array
            {
                Console.WriteLine("Oops. Please select an index between 0 and 6."); //try b/w these numbers
                strIndexGuess = Convert.ToInt32(Console.ReadLine()); //reassigning
            }
            else //the input fits the relevant index identifiers
            {
                //user input is relevant to array and their choice is displayed
                //using the [index] of the array
                Console.WriteLine("That index correlates to: " + strArray[strIndexGuess]); 
                Console.WriteLine("Press \"Enter\" to continue."); //because readline() will pause the app
                strIndexBool = true; //bool is confirmed to true in order to exit while loop
            }
        } 
        while (!strIndexBool); //as long as the bool is false, continue the loop

        Console.ReadLine(); //pause b4 continuing 

        
        int[] numArray = { 1, 2, 3, 4, 5, 6 }; //integer array w/indices 0-5

        Console.WriteLine("Please select an index number to learn more about this integer array.");
        int numIndexGuess = Convert.ToInt32(Console.ReadLine()); //casting int var from user input
        bool numIndexBool = numIndexGuess < 6 && numIndexGuess > 0; //var true only if int var b/w 0 and 5

        do //check for correct answer before while loop starts
        {
            if (numIndexGuess > 5) //input over 5:
            {
                Console.WriteLine("Oops. Please select an index between 0 and 5.");
                numIndexGuess = Convert.ToInt32(Console.ReadLine()); //new input from user saved to int var
            }
            else if (numIndexGuess < 0) //input under 0:
            {
                Console.WriteLine("Oops. Please select an index between 0 and 5.");
                numIndexGuess = Convert.ToInt32(Console.ReadLine());
            }
            else //input was in relevant param
            {
                //lists int in array corresponding to index entered
                Console.WriteLine("That index correlates to: " + numArray[numIndexGuess]); 
                Console.WriteLine("Press \"Enter\" to continue."); //app pauses due to readline()
                numIndexBool = true; //bool confirmed true to exit while loop
            }
        }
        while (!numIndexBool); //as long as bool is false, continue the loop

        Console.ReadLine(); //pause console b4 continuing
        
        List<string> strListSagan = new List<string>(); //creating a new dynamic list
        //adding different entries to the list
        strListSagan.Add("Extraordinary claims require extraordinary evidence.");
        strListSagan.Add("I don't want to believe. I want to know.");
        strListSagan.Add("The cosmos is within us. We are made of star-stuff. We are a way for the universe to know itself.");
        strListSagan.Add("It pays to keep an open mind, but not so open your brains fall out.");

        Console.WriteLine("Please select an index number to learn more about this list.");
        //cast input as int var for comparison purposes
        int saganListPick = Convert.ToInt32(Console.ReadLine()); 
        // b/c lists have no fixed length and can change, used the .Count method to get amount of indices in list
        //but I noticed that the .Count method returns a value +1 over the already added entries. When I ran 
        //the app and entered "4" nothing would happen and it stalled. So 1 has to be subtracted from .Count result
        //to prevent user from selecting it
        int saganStringCount = strListSagan.Count - 1; 
        //bool true when input is between 0 and 3 (relevant indices)
        bool saganListTruth = saganListPick < strListSagan.Count && saganListPick > 0;

        do //b4 while loop check for relevant input
        {
            if (saganListPick > saganStringCount) //when input is too high:
            {
                //writing a response: have to use a var b/c lists are dynamic
                Console.WriteLine("Oops. Please select an index between 0 and " + saganStringCount + ".");
                saganListPick = Convert.ToInt32(Console.ReadLine()); //changing var with new input
            }
            else if (saganListPick < 0) //input is too low
            {
                Console.WriteLine("Oops. Please select an index between 0 and and " + saganStringCount + ".");
                saganListPick = Convert.ToInt32(Console.ReadLine());
            }
            else //input is relevant to available indices
            {
                Console.WriteLine("That index correlates to: " + strListSagan[saganListPick]); //user's result
                Console.WriteLine("Press \"Enter\" to continue."); //enter to move on due to readline()
                saganListTruth = true; //to exit while loop
            }
        }
        while (!saganListTruth); //continue until relevant input is collected

        Console.ReadLine(); //pause b4 ending app
    }
}

