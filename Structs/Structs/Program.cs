﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            n.Amount = 2.4m;
            Console.WriteLine(n.Amount);
            Console.ReadLine();
        }
    }
}
