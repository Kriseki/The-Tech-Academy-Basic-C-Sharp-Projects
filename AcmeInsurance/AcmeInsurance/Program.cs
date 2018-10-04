using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Thank you for considering Acme Insurance.");
            Console.WriteLine("In order for us to best serve you please complete our questionnaire.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            //Questions
            Console.WriteLine("What is your age?");
            string theirAge = Console.ReadLine();
            int age = Convert.ToInt32(theirAge);
            Console.WriteLine();
            Console.WriteLine("Have you ever had a DUI? (true or false)");
            string dui = Console.ReadLine();
            bool theirDui = Convert.ToBoolean(dui);
            Console.WriteLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string theirSpeed = Console.ReadLine();
            int speed = Convert.ToInt32(theirSpeed);
            Console.WriteLine();

            //Results
            Console.WriteLine("Did you qualify?");
            Console.WriteLine(age > 15 && theirDui == false && speed <= 3);
            Console.ReadLine();
        }
    }
}
