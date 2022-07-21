using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMethodsAndObjects
{
    //3. create Employee class that inherits Person class
    public class Employee : Person
    {
        //add another property only for employees called Id w/data type int
        public int Id { get; set; }
    }
}
