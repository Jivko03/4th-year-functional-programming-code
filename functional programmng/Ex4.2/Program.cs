using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._2
{

    public delegate double Function(double x);
    internal class Program
    {
        static void Main(string[] args)
        {

            Function f1 =(double x)=>
            {
                return x * x + 4 * x - 5;
            };
            Function f2 =(double x)=>
            {
                return x * x * x - x * x + 2 * x + 6;
            };
            Function f3 = (double x) =>
            {
                if (x > 0)
                    return (3 * x * x - 1) / Math.Sqrt(x);
                else
                    return 0.0;
            };
            Function f4 = (double x) =>
            {
                if (x <= 0) return 2;
                if (x > 0 && x < 1) return x + 2;
                if (x >= 1 && x <= 2) return 3;
                if (x > 2 && x < 3) return 5 - x;
                return 2;
            };
            Console.WriteLine(f1(2));
            Console.WriteLine(f2(1));
            Console.WriteLine(f3(0));
            Console.WriteLine(f3(4));
            Console.WriteLine(f4(-1));
            Console.WriteLine(f4(0.5));
            Console.WriteLine(f4(1));
            Console.WriteLine(f4(2.5));
            Console.WriteLine(f4(3));
        }
    }
}
