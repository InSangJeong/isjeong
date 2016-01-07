using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    struct doubleCalculator : ICalculator<double>
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Difference(double a, double b)
        {
            return a - b;
        }
        public double Max(List<double> a)
        {
            if (a == null)
                return double.MinValue;

            return a.Max();
        }
        public double Min(List<double> a)
        {
            if (a == null)
                return double.MaxValue;

            return a.Min();
        }
    }

}