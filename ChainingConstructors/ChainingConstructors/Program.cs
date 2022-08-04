using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //create construct
            const string companyName = "Bits & Bobs";
            //implicit var creation
            var name1 = "BMO";
            var name2 = "Willy";
            var id1 = 105;
            var id2 = 113;
            //instan. 4 Employee objects using various information input patterns
            Employee emp1 = new Employee(), emp2 = new Employee(id1), 
                emp3 = new Employee(name1), emp4 = new Employee(id2, name2);
            //displaying results of different input patterns & chained constructors
            Console.WriteLine("Employee {0} named {1} works at {2}", emp1.Id, emp1.Name, companyName);
            Console.WriteLine("Employee {0} named {1} works at {2}", emp2.Id, emp2.Name, companyName);
            Console.WriteLine("Employee {0} named {1} works at {2}", emp3.Id, emp3.Name, companyName);
            Console.WriteLine("Employee {0} named {1} works at {2}", emp4.Id, emp4.Name, companyName);
            //pause
            Console.ReadLine();
        }
    }
}
