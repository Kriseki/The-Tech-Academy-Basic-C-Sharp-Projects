using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee n = new Employee();
            n.ID = 001;
            Employee m = new Employee();
            m.ID = 002;

            n.GetID(n.ID, m.ID);
            
            Console.ReadLine();

        }
    }
}
