using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA1
{
    internal class Linear
    {
        public double a;
        public double b;
        
        public Linear(double a, double b)
        {
            this.a = a;
            this.b = b;

        }

        public void Print() 
        {
            if (b < 0) 
            {
                Console.WriteLine($"y = {a}x - {Math.Abs(b)}"); 
            }
            else if (a == 0)
                { Console.WriteLine($"y={b}"); }
            else if (a<0&&b<0)
            { Console.WriteLine($"y={a}x-{Math.Abs(b)}"); }
            else if (b==0)
            { Console.WriteLine($"y={a}x"); }
            else if (a==0&&b==0)
            { Console.WriteLine($"y=0"); }

            else { Console.WriteLine($"y={a}x+{b}"); }
        }

        public double Y(double x)
        {
            return a * x + b;
        }
    }
}