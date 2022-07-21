using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMethodsAndObjects
{
    //1. make public class Person
    public class Person
    {
        //Two properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //2. void method combining and displaying first and last names of Person
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
