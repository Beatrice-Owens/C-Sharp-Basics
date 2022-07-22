using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub
{
    //3. create Employee class that inherits from Person
    public class Employee : Person
    {
        //4. implement SayName() from Person inside Employee
        public override void SayName()
        {
            base.SayName();
        }
    }
}
