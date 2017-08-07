using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveryDay.Calc.Calculation
{
    public class Calculator
    {
        public double Sum(int x, int y)
        {
            return x + y;
        }

        public double Div(int x, int y)
        {
            return y == 0 ? 0 : x / y;
        }
        
        public int Squa(int x)
        {
            return x * x;
        }
        public double MySqrt(int x)
        {
            return Math.Sqrt(x);
        }

        public double Mult(int x, int y)
        {
            return x * y;
        }
        public double Subt(int x, int y)
        {
            return x - y;
        }
    }
}
