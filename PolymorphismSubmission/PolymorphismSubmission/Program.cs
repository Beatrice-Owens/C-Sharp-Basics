using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //From previous assignments
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.SayName();

            //inst. quitter obj type IQuittable with new Employee class state and behavior
            IQuittable quitter = new Employee();
            quitter.Quit(); //quitter has access to method implemented in Employee class
        }
    }
}
