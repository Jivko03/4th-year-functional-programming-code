using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public delegate double Calc(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc add = (double x, double y) => { return x + y; };
            Calc sub = (double x, double y) => { return x - y; };
            Calc mult = (double x, double y) => { return x * y; };
            Calc dev = (double x, double y) => { if (x != 0) { return x / y; } else { return 0; } };
            Console.WriteLine(add(5,5));
            Console.WriteLine(sub(5,5));
            Console.WriteLine(mult(5,5));
            Console.WriteLine(dev(5,5));
        }
    }
}
