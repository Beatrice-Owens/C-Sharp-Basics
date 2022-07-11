using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console input is always str which must be cast as correct data types
            Console.WriteLine("Car Insurance Approval Process");
            Console.WriteLine("Enter your age."); //asking the ??
            string age = Console.ReadLine(); //taking input as a str var
            int ageCast = Convert.ToInt32(age); //casting str as int in order to compare using bool
            bool overFifteen = ageCast > 15; //bool comparison of whether applicant is over 15 y.o.

            //instrucing user to use true or false to eliminate confusion
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false.\""); 
            string dUI = Console.ReadLine();
            bool dUICast = Convert.ToBoolean(dUI); //turning the true/false entry into bool
            bool anyDUI = dUICast == false; //making sure the input is false

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsCast = Convert.ToInt32(tickets);
            bool ticketNumber = ticketsCast <= 3; //can be 3 or less

            bool approved = overFifteen && anyDUI && ticketNumber; //all criteria must be true

            Console.WriteLine("Qualified?");
            Console.WriteLine(approved); //returning the result

            Console.ReadLine();
        }
    }
}
