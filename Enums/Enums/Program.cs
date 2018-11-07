using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week");
            string day = Console.ReadLine();

            try
            {
                daysOfTheWeek days = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), day);
                Console.WriteLine("Today's day is {0}", day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            


        }
        enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
