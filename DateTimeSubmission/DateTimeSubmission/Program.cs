using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime currentTime = DateTime.Now;
            //sets var for current datetime; downside is var won't update datetime to current time
            //with each subsequent call, so only way to keep it accurate is to write DateTime.Now everytime
            //unless you want to do something to the DT established when currentTime was set

            //display actual current time
            Console.WriteLine("The current time is {0}.", DateTime.Now);
            Console.WriteLine("Please enter a number to add to the current time.");
            //convert input to int for adding to currentTime
            int hoursAdded = Convert.ToInt32(Console.ReadLine());
            //displaying result of adding input # to current DT
            Console.WriteLine("{0} + {1} hour(s) = {2}", DateTime.Now, hoursAdded, DateTime.Now.AddHours(hoursAdded));
            //pause
            Console.ReadLine();
        }
    }
}
