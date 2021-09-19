using System;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// Calling the S(x,n) library method from MyLib2.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть дiйсне число х: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть членiв ряду n: ");
            int n = int.Parse(Console.ReadLine());
            double my_summa = MyLib2.Class1.S(x, n);
            Console.WriteLine("Сума членiв ряду: {0}", my_summa);
        }
    }
}
