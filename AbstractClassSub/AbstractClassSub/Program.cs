using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.a instan. Employee class object employee w/first and last names
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //5.b call method to use on employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
