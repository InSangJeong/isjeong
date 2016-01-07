using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    public class Calculator<T>
    {
        public Type GetCalculatorType()
        {
            Type tType = typeof(T);
            Type calculatorType = null;
            if (tType == typeof(Int32))
            {
                calculatorType = typeof(int32Calculator);
            }
            else if (tType == typeof(Double))
            {
                calculatorType = typeof(doubleCalculator);
            }
            else
            {
                throw new InvalidCastException(String.Format("No exist Type"));
            }
            return calculatorType;
        }
        private ICalculator<T> fCalculator = null;
        public ICalculator<T> calculator
        {
            get
            {
                if (fCalculator == null)
                {
                    MakeCalculator();
                }
                return fCalculator;
            }
        }
        public void MakeCalculator()
        {
            Type calculatorType = GetCalculatorType();
            fCalculator = Activator.CreateInstance(calculatorType) as ICalculator<T>;
        }

        public T Sum(T a, T b)
        {
            return calculator.Sum(a, b);
        }
        public T Difference(T a, T b)
        {
            return calculator.Difference(a, b);
        }
        public T Max(List<T> a)
        {
            return calculator.Max(a);
        }
        public T Min(List<T> a)
        {
            return calculator.Min(a);
        }
    }
}
