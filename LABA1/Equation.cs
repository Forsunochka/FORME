using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LABA1
{
    internal class Equation
    {
        public double a;
        public double b;
        public double c;

        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Print()
        {
            if (a == 0) { Console.WriteLine($"{b}x+{c}=0"); }
            else if (b == 0) { Console.WriteLine($"{a}x*x+{c}=0"); }
            else if (c == 0) { Console.WriteLine($"{a}*x*x+{b}x=0"); }
            else if (a == 0 && c == 0) { Console.WriteLine($"{b}x=0"); }
            else if (a == 0 && b == 0 && c == 0) { Console.WriteLine($"0=0"); }
            else if (b == 0 && c == 0) { Console.WriteLine($"{a}x*x=0"); }
            else if (a < 0) { Console.WriteLine($"{a}x*x+{b}x+{c}=0"); }
            else if (b < 0) { Console.WriteLine($"{a}x*x-{Math.Abs(b)}x+{c}=0"); }
            else if (c < 0) { Console.WriteLine($"{a}x*x+{b}x-{Math.Abs(c)}=0"); }
            else if (a < 0 && c < 0) { Console.WriteLine($"{a}x*x+{b}x-{Math.Abs(c)}=0"); }
            else if (a < 0 && b < 0) { Console.WriteLine($"{a}x*x-{Math.Abs(b)}x+{c}=0"); }
            else if (b < 0 && c < 0) { Console.WriteLine($"{a}x*x-{Math.Abs(b)}x-{Math.Abs(c)}=0"); }
            else
            {
                Console.WriteLine($"{a}x*x+{b}x+{c}=0");
            }

        }
        public double RootCount()
        {
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                return 0;
            } else if (d == 0)
            {
                return 1;
            }
            return 2;


        }
    }
}
