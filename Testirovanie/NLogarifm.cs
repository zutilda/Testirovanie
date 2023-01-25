using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testirovanie
{
    internal class NLogarifm
    {
        public  double LN(double x)
        {
            if (x < 1)
            {
                return -LN(1 / x);
            }
            double e = 1, a = (x - e) / (x + e), b = a * a, p = a, s = a, q = e;
            while (e > 1e-18)
            {
                q += 2;
                p *= b;
                e = p / q;
                s += e;
            }
            double result = 2 * s;
            Program.outputInfo("Result.csv", Math.Round(result, 2), "LN", x);
            return result;
        }
    }
}
