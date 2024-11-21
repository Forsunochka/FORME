using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2._1
{
    internal class Box
    {
        private double lenght;
        public double Lenght
        { 
        get { return lenght; }
            set
            { if (value <= 0)
                { Console.WriteLine($"Error, lenght should be >0"); }
                else
                { lenght = value; }
            }
        }
        private double width;
        public double Width
        { get { return width; }
            set
            { if (value <= 0)
                { Console.WriteLine($"Error, width should be >0"); } 
            else { width = value; }
            }
        }
        private double depth;
        public double Depth
        { get { return depth; }
        set
            { if ( value <= 0)
                { Console.WriteLine($"Eror, depth should be >0"); }
            else {  depth = value; }
            }
        }

        public Box(double lenght, double width, double depth)
        {
            Lenght = lenght;
            Width = width;
            Depth = depth;
        }
        public void Print()
        {
            Console.WriteLine($"Box:{Lenght};{Width};{Depth}");
        }

        public static bool operator == (Box box1, Box box2)
        {
            return box1.Lenght * box1.Width * box1.Depth == box2.Lenght * box2.Width * box2.Depth;
        }

        public static bool operator != (Box box1, Box box2) 
        {
            return box1.Lenght * box1.Width * box1.Depth != box2.Lenght * box2.Width * box2.Depth;
        }

        public override string ToString()
        {
            return $"Box:{Lenght};{Width};{Depth}";
        }
        public static Box operator +(Box left, Box right)
        {
            double maxWidth = 0;
            if (left.Width>=right.Width) { maxWidth = left.Width; }
            else { maxWidth = right.Width; }
            double maxDepth = 0;
            if (left.Depth>=right.Depth) { maxDepth = left.Depth; }
            else { maxDepth = right.Depth; }

            return new Box(left.Lenght + right.Lenght,maxWidth,maxDepth );
        }
        public static Box operator -(Box left, Box right)
        {
            double maxWidth = 0;
            if (left.Width >= right.Width) { maxWidth = left.Width; }
            else { maxWidth = right.Width; }
            double maxDepth = 0;
            if (left.Depth >= right.Depth) { maxDepth = left.Depth; }
            else { maxDepth = right.Depth; }
            return new Box(right.Lenght - left.Lenght, maxWidth, maxDepth);
        }
    }
}
