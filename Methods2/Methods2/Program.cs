using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Math n = new Math();
            n.Addition(10, 30);
            n.Addition(a: 20, b: 40);
            Console.ReadLine();
        }
    }
}
