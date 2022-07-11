using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //console inputs are always str so had to create str var b4 casting to the correct type
            Console.WriteLine("Anonymous Income Comparison Program"); //title
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate."); //getting input
            string p1HourlyRate = Console.ReadLine(); //creating var
            double p1HRCast = Convert.ToDouble(p1HourlyRate); //casting to double for math and b/c of likely decimal usage

            Console.WriteLine("Please enter your hours worked per week.");
            string p1HoursWorked = Console.ReadLine();
            double p1WorkedCast = Convert.ToDouble(p1HoursWorked);
            double p1WeeksPay = p1HRCast * p1WorkedCast; //went ahead and calculated how much p1 makes in a week

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate.");
            string p2HourlyRate = Console.ReadLine();
            double p2HRCast = Convert.ToDouble(p2HourlyRate);

            Console.WriteLine("Please enter your hours worked per week.");
            string p2HoursWorked = Console.ReadLine();
            double p2WorkedCast = Convert.ToDouble(p2HoursWorked);
            double p2WeeksPay = p2HRCast * p2WorkedCast; //calculated how much p2 makes/week

            double p1Salary = p1WeeksPay * 52.0; //multiplying by 52 (weeks in a year) to get rough estimate of annual income
            double p2Salary = p2WeeksPay * 52.0; // ^^
            bool p1VsP2 = p1Salary > p2Salary; //taking 2 previous var and comparing them

            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(p1Salary); //displaying annual salary
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(p2Salary);

            Console.WriteLine("Does Person 1 make more money that Person 2?");
            Console.WriteLine(p1VsP2); //returning the outcome of the bool comparison

            Console.ReadLine(); //so the console app doesn't auto terminate
        }
    }
}
