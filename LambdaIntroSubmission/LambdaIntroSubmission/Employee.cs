using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaIntroSubmission
{
    //create class Employee
    public class Employee
    {
        //constructor to take in parameters from main Program
        public Employee (int id, string firstName, string lastName)
        {
            //passes values to properties
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        //three properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
