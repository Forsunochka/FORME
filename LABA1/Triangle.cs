using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA1
{
    internal class Triangle
    {
        
        private int a;
        public int A
        {
            get { return a; }
            set {
                if (value <= 0)
                { Console.WriteLine("Error, a should be > 0 !"); }
                else { a = value; }
            }
        }
        private int b;
public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                { Console.WriteLine("Error, b should be > 0 !"); }
                else { b = value; }
            }
        }
        private int angle;
        public int ANGLE
        {
            get { return angle; }
            set
            {
                if (value < 0||value>=180)
                { Console.WriteLine("Error, wrong data !!!"); }
                else { angle = value; }
            }
        }
        public Triangle(int a, int b, int angle) 
        {
            A = a;
            B = b;
            ANGLE = angle;
        }

        public double S()
        {
            return A * B * Math.Sin(ANGLE*Math.PI/180) / 2;
        }

        public void Print()
        {
            Console.WriteLine($"Triangle:{A},{B},{ANGLE}");
        }
    }
}
