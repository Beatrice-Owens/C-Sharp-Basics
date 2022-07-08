using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //intro and getting name of student
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine(); //creating a string var based on input
            Console.WriteLine("Your name is: " + studentName); //returning the entered info to the user
            

            Console.WriteLine("What course are you on?"); //course name gathering
            string studentCourse = Console.ReadLine(); //str var based on input again
            Console.WriteLine("Your current course is: " + studentCourse);

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine(); //console input is always a str, so a str var must be created first
            int coursePage = Convert.ToInt32(pageNumber); //the str var is converted to an integer
            Console.WriteLine("You are on page: " + coursePage); //entered info is returned

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string needHelp = Console.ReadLine(); //console always gives a str; create str var first again
            bool helpNeeded = Convert.ToBoolean(needHelp); //convert to a bool var
            Console.WriteLine("You answered: " + needHelp); //used the str var to return info b/c why keep doing conversions

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperiences = Console.ReadLine(); //str var
            Console.WriteLine("You said: " + posExperiences);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine(); //str var to save info again
            Console.WriteLine("You resopnded: " + otherFeedback);

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine(); //str var created to store console entry 
            int studyHours = Convert.ToInt32(hoursStudied); //then converted to int again 
            Console.WriteLine("Good job! You studied " + studyHours + " hours today.");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); //ReadLine() so the console app doesn't just close on its own

        }
    }
}
