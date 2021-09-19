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
            Console.WriteLine("Введiть значення eps:");
            double eps = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть значення х:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть кiлькiсть членiв ряду:");
            int n = int.Parse(Console.ReadLine());

            double S = ClassLibrary3.Class1.S(eps, n, x);
            double func = ClassLibrary3.Class1.func(x);
            double T = ClassLibrary3.Class1.T(S, func);

            Console.WriteLine("Сума ряду = {0}, точне значення функцiї для х = {1}, помилка обчислень = {2}", S, func, T);
            Console.ReadKey();
        }
    }
}
