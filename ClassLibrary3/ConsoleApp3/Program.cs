using System;

namespace ConsoleApp3
{
    class Program
    {
        /// <summary>
        /// Call the library method S, func, T with Class1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int eps;
            do
            {
                Console.WriteLine("Введiть значення eps:");
                eps = int.Parse(Console.ReadLine());
            }
            while (eps <= 0);

            double n;
            do
            {
                Console.WriteLine("Введiть кiлькiсть членiв ряду:");
                n = double.Parse(Console.ReadLine());
            }
            while (n % 1 != 0 || n <= 0);

            Console.WriteLine("Введiть значення х:");
            double x = double.Parse(Console.ReadLine());

            double S = ClassLibrary3.Class1.S(eps, n, x);
            double func = ClassLibrary3.Class1.func(eps, x);
            double T = ClassLibrary3.Class1.T(eps, S, func);

            Console.WriteLine("Сума ряду = {0}, точне значення функцiї для х = {1}, помилка обчислень = {2}", S, func, T);
            Console.ReadKey();
        }
    }
}
