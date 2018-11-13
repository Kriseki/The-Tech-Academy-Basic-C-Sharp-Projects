using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Please enter your age.");
                int theirAge = Convert.ToInt32(Console.ReadLine());
                Person n = new Person(theirAge);
                Console.WriteLine("You were born in the year {0}.", n.year);
                Console.ReadLine();
            }
            catch (AgeException)
            {
                Console.WriteLine("You entered a 0 or negative. Please enter a valid age.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
