﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciProgram
{
    public class FibbonacciSeries
    {
        public void CheckSeries()
        {
            Console.WriteLine("Check Fibonacci Series");

            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
            }
        }
    }
}
    

