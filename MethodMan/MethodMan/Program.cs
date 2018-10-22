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
            Console.WriteLine("Pick a number and let Method Man do some math.");
            int a = Convert.ToInt32(Console.ReadLine());
            int ret;
            int ret2;
            int ret3;
            Math n = new Math();

            ret = n.Multiply(a);
            ret2 = n.Addition(a);
            ret3 = n.Subtract(a);
            Console.WriteLine("Your number times 10 = " + ret);
            Console.WriteLine("Your number plus 10 = " + ret2);
            Console.WriteLine("Your number minus 10 = " + ret3);
            Console.ReadLine();

        }
    }
}
