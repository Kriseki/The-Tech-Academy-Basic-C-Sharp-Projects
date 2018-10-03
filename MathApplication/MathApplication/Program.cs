using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math is Great Application!");
            Console.WriteLine("Please press enter to start.");
            Console.WriteLine();

            //Multiplication
            Console.WriteLine("Please provide your number.");
            string theirMult = Console.ReadLine();
            long theirMulti = Convert.ToInt64(theirMult);
            long multiTotal = theirMulti * 50;
            Console.WriteLine("Your number times 50 equals: " + multiTotal);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            //Addition
            Console.WriteLine("Please provide another number.");
            string thierAddition = Console.ReadLine();
            int theirAdd = Convert.ToInt32(thierAddition);
            int addTotal = theirAdd + 25;
            Console.WriteLine("Your number plus 25 equals: " + addTotal);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            //Division
            Console.WriteLine("Please provide another number.");
            string theirDivision = Console.ReadLine();
            double theirDiv = Convert.ToDouble(theirDivision);
            double quotient = theirDiv / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            //Greater Than
            Console.WriteLine("Please provide another number.");
            string theirNumber = Console.ReadLine();
            int theirNum = Convert.ToInt32(theirNumber);
            bool isMore = theirNum > 50;
            Console.WriteLine("Your number is great than 50: " + isMore);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            //Remainder
            Console.WriteLine("Please provide another number.");
            string theirRemainder = Console.ReadLine();
            int theirRemain = Convert.ToInt32(theirRemainder);
            int remainder = theirRemain % 7;
            Console.WriteLine("Your number divided by 7 gives a remainder of: " + remainder);
            Console.ReadLine();

            Console.WriteLine("Thank you for visiting!");
            Console.ReadLine();
        }
    }
}
