using System;

namespace MyLib
{
    /// <summary>
    /// Calculation of mathematical functions
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Mean(x,y)
        /// </summary>
        /// <param name="x">the first argument</param>
        /// <param name="y">the second argument</param>
        /// <returns>returns the value of the Mean function</returns>
        public static double Mean(double x, double y)
        {
            double res;
            res = (x + y) / 2;
            return res;
        }
    }
}
