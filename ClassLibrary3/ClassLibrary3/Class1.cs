using System;

namespace ClassLibrary3
{
    public class Class1
    {
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="eps">first argument of the S (epsilon number)</param>
        /// <param name="n">second argument of the S (number of members)</param>
        /// <param name="x">third argument of the S</param>
        /// <returns>returns the value of the S</returns>
        public static double S(double eps, int n, double x)
        {
            double S = 0;
            for (int i = 1; i <= n; i++)
            {
                S = S + Math.Pow(x, 2 * n) / fact(2 * n + 1);
                if (Math.Abs(S) < eps)
                { break; }
            }
            return S;
        }

        /// <summary>
        /// factorial
        /// </summary>
        /// <param name="n">number of members</param>
        /// <returns>returns the value of the fact</returns>
        static double fact(int n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }

        /// <summary>
        /// T
        /// </summary>
        /// <param name="S">first argument of the T</param>
        /// <param name="func">second argument of the T</param>
        /// <returns></returns>
        public static double T(double S, double func)
        {
            double T = Math.Abs(S - func) / func * 1;
            return T;
        }

        /// <summary>
        /// func
        /// </summary>
        /// <param name="x">first argument of the func</param>
        /// <returns></returns>
        public static double func(double x)
        {
            double func = (Math.Exp(x) + Math.Exp(-x)) / 2;
            return func;
        }
    }
}
