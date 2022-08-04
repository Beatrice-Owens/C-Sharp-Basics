using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainingConstructors
{
    public class Employee
    {
        //chaining constructors
        //no param for input from Program, passes default 0, default ""
        public Employee() : this(0, "Momo")
        {
        }
        //int var id param, passes id, default ""
        public Employee(int id) : this(id, "Toph")
        {
        }
        //only str var name param, passes default 0, name
        public Employee(string name) : this(0, name)
        {
        }
        //base constructor takes id and name params and assigns to props
        public Employee(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
        //properties
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
