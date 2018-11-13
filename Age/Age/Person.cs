using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    public class Person
    {
        public int year { get; set; }

        public Person(int theiryear)
        {
            if (theiryear <= 0)
            {
                throw new AgeException();
            }
            else
            {
                year = DateTime.Now.Year - theiryear;
            }
        }
    }
}
