using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. instan. Employee class object employee w/first and last names
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //5. call superclass method to use on employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
