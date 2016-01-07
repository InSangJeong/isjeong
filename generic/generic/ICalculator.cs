using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    public interface ICalculator<T>
    {
        T Sum(T a, T b);
        T Difference(T a, T b);
        T Max(List<T> a  = null);
        T Min(List<T> a = null);
    }
}
