using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is {0}", DateTime.Now);
            Console.WriteLine("Please provide a number.");
            int hrs = Convert.ToInt32(Console.ReadLine());
            DateTime later = DateTime.Now.AddHours(hrs);
            Console.WriteLine("In {0} more hours it will be {1}", hrs, later);
            Console.ReadLine();
        }
    }
}
