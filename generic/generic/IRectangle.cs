using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    public interface IRectangle<T>
    {
        T StartX { get; set; }
        T StartY { get; set; }

        T EndX { get; set; }
        T EndY { get; set; }

        T Width { get; }
        T Height { get; }
    }
}
