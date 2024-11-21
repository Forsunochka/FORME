using LABA2._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2._1
{
    internal class LinearEquation
    {
        public int[] A { get; set; }
        public int B { get; set; }

        public LinearEquation(int[] A, int B)
        {
            this.A = A; this.B = B;
        }
        // Переопределяем арифметические операторы для работы с дробями 
        public static LinearEquation operator +(LinearEquation first, LinearEquation second)
        {            int lengthMax = Math.Max(first.A.Length, second.A.Length);
        int lengthMin = Math.Min(first.A.Length, second.A.Length); int[] resultA = new int[lengthMax];
            for (int i = 0; i<=lengthMin; i++)
            {                resultA[i] = first.A[i] + second.A[i];
            }            for (int i = lengthMin; i<lengthMax; i++)
            {                if (i > second.A.Length)
                {
                    resultA[i] += first.A[i];                }
                else if (i > first.A.Length)
{
    resultA[i] += second.A[i];
}            }
            int resultB = first.B + second.B; return new LinearEquation(resultA, resultB);
        }
        public static LinearEquation operator -(LinearEquation first, LinearEquation second)
{
    int lengthMax = Math.Max(first.A.Length, second.A.Length);
    int lengthMin = Math.Min(first.A.Length, second.A.Length); int[] resultA = new int[lengthMax];
    for (int i = 0; i < lengthMin; i++)
    {
        resultA[i] = first.A[i] - second.A[i];
    }
    for (int i = lengthMin; i < lengthMax; i++)
    {
        if (i > second.A.Length)
        {
            resultA[i] += first.A[i];
        }
        else if (i > first.A.Length)
        {
            resultA[i] -= second.A[i];
        }
    }
    int resultB = first.B + second.B; return new LinearEquation(resultA, resultB);
}
public override string ToString()
{
    StringBuilder sb = new StringBuilder(""); for (int i = 0; i < A.Length; i++)
    {
        if (i == 0 && A[i] != 0)
        {
            sb.Append($"{A[0]}x{i + 1}");
        }
        else if (A[i] == 0)
        {
            sb.Append("");
        }
        else if (A[i] == 1)
        {
            sb.Append("+x");
        }
        else if (A[i] == -1)
        {
            sb.Append("-x");
        }
        else if (A[i] > 0 && A[i] != 1)
        {
            sb.Append($"+{A[i]}x{i + 1}");
        }
        else if (A[i] < 0 && A[i] != -1)
        {
            sb.Append($"-{-A[i]}x{i + 1}");
        }
    }
    sb.Append($"={B}"); return sb.ToString();
}

    }
}
