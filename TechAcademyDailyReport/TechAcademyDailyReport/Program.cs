using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string currentPage = Console.ReadLine();
            int curPg = Convert.ToInt32(currentPage);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needHelp);
            Console.WriteLine("Were there any positie exerperiences you'd like to share? Please give specifics");
            string posEx = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to share? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursStudy = Convert.ToInt32(hours);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great Day!");
            Console.ReadLine();
        }
    }
}
