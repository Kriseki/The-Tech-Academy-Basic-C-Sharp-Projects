using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math n = new Math();
            Console.WriteLine(n.Addition(12));
            Console.WriteLine(n.Addition(10.5m));
            Console.WriteLine(n.Addition("10"));
            Console.ReadLine();
        }
    }
}
