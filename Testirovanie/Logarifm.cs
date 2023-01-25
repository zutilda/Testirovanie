using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testirovanie
{
    internal class Logarifm
    {
         public static double Log(double x)
        {
          int i;
          for (i = 0; i < 100; i++)
            {
                if(Math.Pow(5,i)==x)
                {
                    return i;
                }                
            }
            return i;
        }
        public  double lgShow(double x)
        {
            double result = Log(x);
            Program.outputInfo("Result.csv", Math.Round(result, 2), "lgShow", x);
            return result;
        }
    }
}
