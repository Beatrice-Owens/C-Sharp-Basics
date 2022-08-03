using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the number and assign it to str var b/c no math and I'm just writing & reading with it
            Console.WriteLine("Hello. Please enter a number.");
            string numberEntry = Console.ReadLine();
            //write the str in numberEntry to the path listed for logging purposes
            File.WriteAllText(@"C:\Users\point\Logs\logPractice.txt", numberEntry);
            //create a str var that reads the txt file at target path 
            string readLog = File.ReadAllText(@"C:\Users\point\Logs\logPractice.txt");
            //now write info contained in the file to console
            Console.WriteLine(readLog);
            //pause b4 moving on
            Console.ReadLine();
        }
    }
}
