using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    public class Math
    {
        public int Addition(int num1)
        {
            int result = num1 + 10;
            return result;
        }

        public int Addition(decimal num2)
        {
            decimal result2 = num2 * 2;
            int result22 = Convert.ToInt32(result2);
            return result22;
        }

        public int Addition(string num3)
        {
            int num33 = Convert.ToInt32(num3);
            int result3 = num33 - 5;
            return result3;
        }
    }
}
