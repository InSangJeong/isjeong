using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    struct int32Calculator : ICalculator<Int32>
    {
        public Int32 Sum(Int32 a, Int32 b)
        {
            return a + b;
        }

        public Int32 Difference(Int32 a, Int32 b)
        {
            return a - b;
        }
        public Int32 Max(List<Int32> a)
        {
            if (a == null)
                return Int32.MinValue;

            return a.Max();
        }
        public Int32 Min(List<Int32> a)
        {
            if (a == null)
                return Int32.MaxValue;

            return a.Min();
        }
    }
}
