﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testirovanie
{
    internal class Cosin
    {
        static double Factorial(int num)
        {
            if (num <= 1)
            {
                return 1d;
            }

            return num * Factorial(num - 1);
        }


        public double Cos(double x, int n = 0, double precision = 0.0000000000000000001)
        {
            double t = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
            if (Math.Abs(t) < precision)
            {
                return t;
            }

            double result = t + Cos(x, n + 1, precision);
            Program.outputInfo("Result.csv", Math.Round(result, 2), "Cos", x);
            return result;
        }

     
    }

}
