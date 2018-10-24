using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {
            Math n = new Math();

            Console.WriteLine("Pick a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number if you want or hit enter to use the default number of 5.");
            string num2 = Console.ReadLine();
            Console.WriteLine("We will now add the first number to the second number.");
            if (num2 == "")
            {
                Console.WriteLine("Your answer is: " + n.Addition(num1));
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                Console.WriteLine("Your answer is: " + n.Addition(num1, num3));
            }
            Console.ReadLine();
        }
    }
}
