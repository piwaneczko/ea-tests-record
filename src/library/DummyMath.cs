using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public static class DummyMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0) throw new ArgumentException("Cannot divide with 0", nameof(b));
            return a / b;
        }
        /// <summary>
        /// Pow function with bug
        /// </summary>
        /// <param name="a">basis of pow</param>
        /// <param name="b">power value</param>
        /// <returns></returns>
        public static double Pow(double a, double b)
        {
            return Math.Pow(b, a);
        }
    }
}
