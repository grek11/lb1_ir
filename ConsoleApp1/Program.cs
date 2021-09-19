using System;


namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Calling the Mean(x,y) library method from MyLib.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть друге число: ");
            double y = double.Parse(Console.ReadLine());
            double my_mean = MyLib.Class1.Mean(x, y);
            Console.WriteLine("Середнє арифметичне значення двох чисел = {0}", my_mean);
            
        }
    }
}
