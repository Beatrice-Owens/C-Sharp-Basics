using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    //Employee class inherits class Person and interface IQuittable
    public class Employee : Person, IQuittable
    {
        //implement SayName() from Person inside Employee
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        //implement Quit() from IQuittable interface inside Employee
        public void Quit()
        {
            Console.WriteLine("I Quit!"); //write statement when method is called
            Console.ReadLine(); //pause
        }
    }
}
