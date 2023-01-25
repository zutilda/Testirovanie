using System;

namespace Testirovanie // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static double first(double x)
        {
            x = (x * Math.PI) / 180;
            Console.WriteLine("Значение x  в радианах = " + Math.Round(x, 4));

            Sinus sin = new Sinus();
            double s = sin.sinShow(x);
            Cosin cos = new Cosin();
            double c = cos.cosShow(x);
            Console.WriteLine("sin = " + Math.Round(s, 2) + ", cos = " + Math.Round(c, 2));

            double otv = s + c + Math.Pow(c, 2);
            Console.WriteLine("Результат вычислений = " + Math.Round(otv, 4));
            outputInfo("Result.csv", Math.Round(otv, 4), "first", x);
            return Math.Round(otv, 4);
        }

        public static double second(double x)
        {
            NLogarifm nl = new NLogarifm();
            double ln = nl.lnShow(x);
            Console.WriteLine("ln = " + Math.Round(ln, 2) + ", math = " + Math.Round(Math.Log(x), 2));

            Logarifm lg = new Logarifm();
            double log = lg.lgShow(x);
            Console.WriteLine("log = " + Math.Round(log, 2) + ", math = " + Math.Round(Math.Log(x, 5), 2));

            double otv = ln * log;
            Console.WriteLine("Результат вычислений = " + Math.Round(otv, 4));
            outputInfo("Result.csv", Math.Round(otv, 4), "second", x);
            return Math.Round(otv, 4);
        }

        public static void outputInfo(string path, double result, string nameMethod, double x)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Результат метода " + nameMethod + ", при x: " + x + " = " + result);
            }
            Console.WriteLine("Данные записаны");

        }
        static void Main(string[] args)
        {
            double x;
            while (true)
            {
                Console.Write("Введите значение x в градусах: ");
                try
                {
                    x = Double.Parse(Console.ReadLine());
                    if (x < 0)
                    {
                    Console.WriteLine(first(x));
                 
                    }
                    else
                    {
                        Console.WriteLine(second(x));
                    }
                    break;
                }
                catch
                {
                    Console.Write("Вы ввели неверное значение! Повторите ввод!");
                }
            }                     
            
        }

    }
}