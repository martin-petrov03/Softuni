using System;

namespace _01.Num_Range_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num > 100 || num < 1)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}