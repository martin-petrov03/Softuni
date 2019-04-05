using System;

namespace _01.Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" = ");
            double a = double.Parse(Console.ReadLine());
            double area = Math.Pow(a, 2);
            Console.WriteLine($"Square = {area}");
            //Console.ReadKey();
        }
    }
}