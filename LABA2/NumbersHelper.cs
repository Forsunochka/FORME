using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2
{
    internal class NumbersHelper
    {
        public static int GetGreatestComminDivisor(int number1, int number2)
        {
            while (number2 != 0)
            {
                int remainder = number1 % number2;
                number1 = number2;
                number2 = remainder;
            }
            return number1;
        }

    }
}
