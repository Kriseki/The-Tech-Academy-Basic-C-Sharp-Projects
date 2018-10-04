using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeShipping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Welcome to Acme Package Express.");
            Console.WriteLine("Please follow the instructions below.");
            Console.WriteLine();

            //Weight
            Console.WriteLine("Package Weight");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Acme Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine();

            //Width
            Console.WriteLine("What is the package width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Height
            Console.WriteLine("What is the package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Length
            Console.WriteLine("What is the package length?");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Dimensions Approval
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Acme Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else 
            {
                int dimTotal = width + height + length;
                decimal total = dimTotal * weight / 100m;
                Console.WriteLine("Your shipping total is $" + total);
            }
            Console.ReadLine();
        }
    }
}
