using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VictoryLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many goals will the Timbers score tonight?");
            string answer = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Desktop\Projects\Logs\timbers.txt", answer);
            Console.WriteLine("We have logged that you predict the Timbers will score " + File.ReadAllText(@"C:\Users\Student\Desktop\Projects\Logs\timbers.txt") + " goals.");
            Console.ReadLine();
        }
    }
}
