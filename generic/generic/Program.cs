using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Int형 Envelope");
            envelope<int> intEnvelope = new envelope<int>();
            intEnvelope.showSize();

            Console.WriteLine("추가 1, 10, 20, 50");
            intEnvelope.addShape(1, 10, 20, 50);
            intEnvelope.showSize();

            Console.WriteLine("추가 -6, 1, 15, 100");
            intEnvelope.addShape(-6, 1, 15, 100);
            intEnvelope.showSize();

            Console.WriteLine("");
            Console.WriteLine("double형 Envelope");
            envelope<double> doubleEnvelope = new envelope<double>();
            doubleEnvelope.showSize();

            Console.WriteLine("추가 1.1, 10.2, 20.2, 50.2");
            doubleEnvelope.addShape(1.1, 10.2, 20.2, 50.2);
            doubleEnvelope.showSize();

            Console.WriteLine("추가 -6.5, 1.1, 15.3, 100.4");
            doubleEnvelope.addShape(-6.5, 1.1, 15.3, 100.4);
            doubleEnvelope.showSize();

        }
    }
}
