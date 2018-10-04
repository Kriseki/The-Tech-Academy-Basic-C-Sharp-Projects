using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            //Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate");
            string hourlyRate1 = Console.ReadLine();
            decimal hourRate1 = Convert.ToDecimal(hourlyRate1);
            Console.WriteLine("Enter Hours worked per week.");
            string hoursWorked1 = Console.ReadLine();
            decimal hourWork1 = Convert.ToDecimal(hoursWorked1);
            Console.WriteLine();

            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter Hourly Rate");
            string hourlyRate2 = Console.ReadLine();
            decimal hourRate2 = Convert.ToDecimal(hourlyRate2);
            Console.WriteLine("Enter Hours worked per week.");
            string hoursWorked2 = Console.ReadLine();
            decimal hourWork2 = Convert.ToDecimal(hoursWorked2);
            Console.WriteLine();

            //Results
            decimal annualSalary1 = hourRate1 * hourWork1 * 52.1429m;
            Console.WriteLine("Annual Salary of Person 1: $" + annualSalary1);
            decimal annualSalary2 = hourRate2 * hourWork2 * 52.1429m;
            Console.WriteLine("Annual Salary of Person 2: $" + annualSalary2);
            bool isMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does person 1 make more than person 2: " + isMore);

            Console.ReadLine();

        }
    }
}
