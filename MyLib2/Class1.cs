using System;

namespace MyLib2
{
    /// <summary>
    /// Calculation of mathematical functions
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="x">first argument</param>
        /// <param name="n">secon argument</param>
        /// <returns>returns the value of the S</returns>
        public static double S(double x, int n)
        {
            double summa = 0;
            for (int i=0; i<n; i++)
            {
                summa = summa + (Math.Pow((-1), i - 1) * Math.Pow(x, (2 * i - 1))) / f(2 * i - 1);
            }
            return summa;
        }

        /// <summary>
        /// factorial
        /// </summary>
        /// <param name="n">number of members</param>
        /// <returns></returns>
        static double f(int n)
        {
            double tmp = 1;
            for (int i = 1; i<=n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }
    }
}
