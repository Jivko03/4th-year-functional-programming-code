using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    internal class Program
    {
        public delegate double FunctionX(double x);
        static void Main(string[] args)
        {
            FunctionX fx1 = delegate (double x)
            {
                return Math.Pow(x, 2)+4*x - 5;
            };
            FunctionX fx2 = delegate (double x)
            {
                return Math.Pow(x, 3) - Math.Pow(x, 2) + 2 * x + 6;
            };
            FunctionX fx3 = delegate (double x)
            {
                if (x > 0) 
                {
                   return (3 * Math.Pow(x, 2) - 1) / Math.Sqrt(x);
                }
                else 
                {
                    return 0.0; 
                }
            };
            FunctionX fx4 = delegate (double x)
            {
                if (x <= 0) { return 2; }
                else return 0;
            };
            FunctionX fx5 = delegate (double x)
            {
                if (x>0 && x<1) { return x + 2; }
                else if (x>=1 && x<=2) { return 3; }
                else if (x>2 && x<3) { return 5 - x; }
                else if (x >=3) { return 2; }
                else { return 0; }
            };
            Console.WriteLine(fx1(2));
            Console.WriteLine(fx2(2));
            Console.WriteLine(fx3(1));
            Console.WriteLine(fx4(0.5));
            Console.WriteLine(fx4(1));
            Console.WriteLine(fx4(2.5));
            Console.WriteLine(fx4(3.5));

        }
    }
}
