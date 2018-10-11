using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamguess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who is the best MLS team?");
            string team = Console.ReadLine();
            bool isGuessed = team == "Timbers";
            do
            {
                switch (team)
                {
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess again.");
                        team = Console.ReadLine();
                        break;

                    case "Sounders":
                        Console.WriteLine("You are very wrong. You should be embarrassed and ashamed.");
                        Console.WriteLine("Guess again");
                        team = Console.ReadLine();
                        break;

                    case "Timbers":
                        Console.WriteLine("That's right!");
                        isGuessed = true;
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
