using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace story
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Short story generator.");
            Console.WriteLine();
            Console.WriteLine("Enter a verb + ing");
            string verb = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter a location.");
            string location = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter another noun.");
            string Noun = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter past tense verb");
            string pastVerb = Console.ReadLine();
            Console.WriteLine();
            string upVerb = verb.ToUpper();
            string upLocation = location.ToUpper();
            string upNoun = Noun.ToUpper();
            string upPast = pastVerb.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append("One day I was " + upVerb + " to " + upLocation + ". ");
            sb.Append("On the way I saw a " + upNoun + ". ");
            sb.Append("This was a surprise so I " + upPast + " quickly. ");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
