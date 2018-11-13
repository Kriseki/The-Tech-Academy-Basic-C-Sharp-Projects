using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Employee
    {
        public Employee(string name) : this(name, "lastName")
        {

        }
        public Employee(string name, string lastName)
        {
            fName = name;
            lName = lastName;
        }
    
        public string fName { get; set; }
        public string lName { get; set; }
    }
}
