using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    //create public class
    public class Employee
    {
        //three properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overload == operator to assess bool value of separate employee Id values
        //returns bool value
        public static bool operator== (Employee employee1, Employee employee2)
        {
            //== now checks if ids are the same
            bool equalId = employee1.Id == employee2.Id;
            return equalId;
        }
        //must overload comparison operators in pairs (== and !=)
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool equalId = employee1.Id != employee2.Id;
            return equalId;
        }
    }
}
