using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){ 50, 60, 70, 80, 90, 100 };
            Console.WriteLine("Pick a number.");
            string userNumber = Console.ReadLine();
            Console.WriteLine("We will now divide the list numbers of 50, 60, 70, 80, 90, 100 by your number.");
            Console.WriteLine();
            try
            {
                foreach (int number in numbers)
                {
                    int userNumber2 = Convert.ToInt32(userNumber);
                    int number3 = number / userNumber2;
                    Console.WriteLine(number + " divided by " + userNumber + " equals " + number3);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Do not divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Program has exited try/catch block.");
            Console.WriteLine("Thank you for participating.");
            Console.ReadLine();
        }
    }
}
