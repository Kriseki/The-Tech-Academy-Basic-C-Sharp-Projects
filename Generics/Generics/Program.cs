using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employee = new List<string> { "one", "two", "three" };
            List<int> employee1 = new List<int> { 1, 2, 3 };
            employee.ForEach(em => Console.WriteLine(em));
            employee1.ForEach(em => Console.WriteLine(em));
            Console.ReadLine();
        }
    }
}
