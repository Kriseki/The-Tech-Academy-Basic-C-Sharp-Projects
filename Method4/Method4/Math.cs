using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    public class Math
    {
        public int Addition(int a, int b = 5)
        {
            int answer = a + b;
            return answer;
        }
    }
}
