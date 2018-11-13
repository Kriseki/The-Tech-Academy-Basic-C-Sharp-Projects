using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "Faux Co";
            Console.WriteLine("Welcome to {0}'s company directory.", companyName);
            Console.WriteLine("Please enter your first name.");
            var firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            var lastName = Console.ReadLine();

            Employee employee = new Employee(firstName, lastName);
            Console.WriteLine("You have entered {0} {1} into the employee directory.",employee.fName, employee.lName);
            Console.WriteLine();
            Employee newEmployee = new Employee("Sample");
            Console.WriteLine("{0} {1} has also been added to the directory.", newEmployee.fName, newEmployee.lName);
            Console.ReadLine();
        }
    }
}
