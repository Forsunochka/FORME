using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2
{
    internal class Rational
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
       
        public Rational(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Reduce();

        }

        public Rational(int numerator)
        { Numerator = numerator;
            Denominator = 1;
        }
        public Rational()
        { Numerator = 1;
            Denominator = 1;
        }
        public override string ToString()
        {
            if (Denominator == 1)
            { return $"{Numerator}"; }
            
            if (Denominator < 0)
            { return $"-{Numerator}/{Math.Abs(Denominator)}"; }

            if (Denominator < 0&& Numerator<0) { return $"{Math.Abs(Numerator)}/{Math.Abs(Denominator)}"; }

            if (Denominator == 0) { Console.WriteLine($"Error, znamenatel ne mozet bit nulem !!!"); }
            return $"{Numerator}/{Denominator}";
        }
        public static Rational operator -(Rational left, Rational right)
        {
            return new Rational(left.Numerator * right.Denominator - right.Numerator * left.Denominator, left.Denominator * right.Denominator);

        }
        public static Rational operator /(Rational left, Rational right)
        {
            return new Rational(left.Numerator * right.Denominator, left.Denominator * right.Numerator);
        }
        public static Rational operator +(Rational left, Rational right)
        {
            return new Rational(left.Numerator * right.Denominator + right.Numerator * left.Denominator, left.Denominator * right.Denominator);
        }
        public static Rational operator *(Rational left, Rational right)
        {
            return new Rational(left.Numerator * right.Numerator, right.Denominator * left.Denominator);
        }

        public void Reduce()
        {
            int GCD=NumbersHelper.GetGreatestComminDivisor(Numerator, Denominator);
            Numerator/= GCD; 
            Denominator/= GCD;
        }
    }
}
