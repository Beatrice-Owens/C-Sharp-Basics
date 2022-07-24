using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and instantiate new Employee class object employee1 w/all 3 properties
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "B",
                LastName = "Mo"
            };

            //declare and instan. another object for comparison
            Employee employee2 = new Employee
            {
                Id = 102,
                FirstName = "D",
                LastName = "Choe"
            };

            //write whether employee1's Id is the same as employee2's
            //then pause
            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
