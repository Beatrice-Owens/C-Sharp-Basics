using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSubmission
{
    class Program
    {
        //defining enum Day with acceptabole values
        public enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            //creating var of type Day to receive input values
            Day currentDay;

            //try this first:
            try
            {
                //enter value & convert that value to enum type Day, accounting for different capitalizations
                //write to console
                Console.WriteLine("Enter the current day of the week.");
                currentDay = (Day) Enum.Parse(typeof(Day), Console.ReadLine(), true); 

                Console.WriteLine("{0} is a day of the week.", currentDay);
            }
            //if ^^ didn't work do this:
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            //pause
            Console.ReadLine();

        }
    }
}
