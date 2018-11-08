using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBambaLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> n = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName = "Smith", ID = 001 },
                new Employee() {FirstName = "Mike", LastName = "Johnson", ID = 002 },
                new Employee() {FirstName = "Joe", LastName = "Williams", ID = 003 },
                new Employee() {FirstName = "Emma", LastName = "Jones", ID = 004 },
                new Employee() {FirstName = "Holden", LastName = "Brown", ID = 005 },
                new Employee() {FirstName = "Esther", LastName = "Davis", ID = 006 },
                new Employee() {FirstName = "Logan", LastName = "Miller", ID = 007 },
                new Employee() {FirstName = "Preston", LastName = "Wilson", ID = 008 },
                new Employee() {FirstName = "Xander", LastName = "Young", ID = 009 },
                new Employee() {FirstName = "Phil", LastName = "Price", ID = 010 }
            };

            List<Employee> m = new List<Employee>();

            foreach (Employee employee in n)
            {
                if (employee.FirstName == "Joe")
                {
                    m.Add(employee);
                    
                }
            }

            List<Employee> p = n.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> q = n.Where(x => x.ID > 5).ToList();

            Console.WriteLine(n.Count);
            Console.WriteLine(m.Count);
            Console.WriteLine(p.Count);
            Console.WriteLine(q.Count);

            Console.ReadLine();
        }
    }
}
