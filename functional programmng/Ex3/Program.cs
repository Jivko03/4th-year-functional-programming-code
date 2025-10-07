using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public delegate double Square(double x);
    public delegate double Rectangle(double x, double y);

    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = (double x) => { return Math.Pow(x,2); };
            Rectangle rectangle = (double x, double y) => { return x*y; };
            Square circle = (double r) => { return Math.PI*Math.Pow(r,2); };
            Rectangle romboid = (double d1, double d2) => {return 0.5 * d1 * d2; };
            Rectangle parallelogram = (double b, double h)=> { return b*h; };

            Console.WriteLine(square(5));
            Console.WriteLine(rectangle(5,5));
            Console.WriteLine(circle(5));
            Console.WriteLine(romboid(5,5));
            Console.WriteLine(parallelogram(10,8));


        }
    }
}
