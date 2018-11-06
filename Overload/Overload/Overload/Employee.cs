using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    public class Employee
    {
        public int ID { get; set; }

        public void GetID(int A, int B)
        {
            int Employee1 = A;
            int Employee2 = B;
            Console.WriteLine("Employee 1 ID: {0}, Employee 2 ID: {1}", A, B);
        }

        public static bool operator == (Employee A, Employee B)
        {
            bool status = false;
            if (A == B)
            {
                status = true;
                Console.WriteLine("IDs are the same.");
            }
            return status;
        }

        public static bool operator != (Employee A, Employee B)
        {
            bool status = false;
            if (A != B )
            {
                status = false;
                Console.WriteLine("IDs are not the same.");
            }
            return status;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
