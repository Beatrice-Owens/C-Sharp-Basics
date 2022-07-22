using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub
{
    //1. create abstract person class
    public abstract class Person
    {
        //Two properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //2. virtual void method combining and displaying first and last names of Person
        public virtual void SayName()
        {
            
        }
    }
}
