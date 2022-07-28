using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaIntroSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list of employees from Employee class
            List<Employee> Employees = new List<Employee>();

            //Adding new items to the list of employees w/values for int id & str fname/lname
            Employees.Add(new Employee(1, "Joe", "White"));
            Employees.Add(new Employee(2, "Jane", "White"));
            Employees.Add(new Employee(3, "Joe", "Blue"));
            Employees.Add(new Employee(4, "Rebecca", "Green"));
            Employees.Add(new Employee(5, "Joe", "Purple"));
            Employees.Add(new Employee(6, "Stacy", "Purple"));
            Employees.Add(new Employee(7, "Violet", "Violet"));
            Employees.Add(new Employee(8, "Momo", "Catus"));
            Employees.Add(new Employee(9, "Martha", "Catus"));
            Employees.Add(new Employee(10, "Toph", "Felis"));

            //create list to receive all entries w/first name Joe
            List<Employee> Joes = new List<Employee>();
            //loop through employee list to find entries with fname Joe
            //then add to Joes list
            foreach (Employee employee in Employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Joes.Add(employee);
                }
            }

            //another loop to print all entries in Joes list to check
            foreach (Employee joe in Joes)
            {
                Console.WriteLine("All Joes: Id: {0}, First Name: {1}, Last Name: {2}", joe.Id, joe.FirstName, joe.LastName);
            }
            Console.ReadLine(); //pause

            //simplified Joes list into single lambda expression
            List<Employee> JoesLambda = Employees.FindAll(x => x.FirstName == "Joe");

            //same loop as before but modified to make sure it worked
            foreach (Employee joe in JoesLambda)
            {
                Console.WriteLine("All Joes: Id: {0}, First Name: {1}, Last Name: {2}", joe.Id, joe.FirstName, joe.LastName);
            }
            Console.ReadLine(); //pause

            //create list based on all entries in Employees list with an Id > 5
            List<Employee> HighID = Employees.FindAll(x => x.Id > 5);

            //write out all items in HighID list
            foreach (Employee employee in HighID)
            {
                Console.WriteLine("All Ids over 5: Id: {0}, First Name: {1}, Last Name: {2}", 
                    employee.Id, employee.FirstName, employee.LastName);
            }
            Console.ReadLine(); //pause
        }
    }
}
