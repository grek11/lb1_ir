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
        public static double S(int eps, double n, double x)
        {
            double S = 0;
            for (int i = 1; i <= n; i++)
            {
                S = S + Math.Pow(x, 2 * n) / fact(eps,(2 * n + 1));
            }
            return Math.Round(S, eps);
        }

        /// <summary>
        /// factorial
        /// </summary>
        /// <param name="eps">epsilon number</param>
        /// <param name="n">number of members</param>
        /// <returns>returns the value of the fact</returns>
        static double fact(int eps, double n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return Math.Round(tmp, eps);
        }

        /// <summary>
        /// T
        /// </summary>
        /// <param name="eps">first argument of the T (epsilon number)</param>
        /// <param name="S">second argument of the T</param>
        /// <param name="func">third argument of the T</param>
        /// <returns></returns>
        public static double T(int eps, double S, double func)
        {
            return Math.Round((Math.Abs(S - func) / func) * 100, eps);
        }

        /// <summary>
        /// func
        /// </summary>
        /// <param name="eps">first argument of the T (epsilon number)</param>
        /// <param name="x">second argument of the func</param>
        /// <returns></returns>
        public static double func(int eps, double x)
        {
            double func = (Math.Exp(x) + Math.Exp(-x)) / 2;
            return Math.Round(func,eps);
        }
    }
}
