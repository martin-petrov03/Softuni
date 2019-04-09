using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Header
            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));

            //Body
            double averageRow = (n - 1) / 2;
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == Math.Ceiling(averageRow))
                {
                    Console.WriteLine('*' + new string('/', n * 2 - 2) + '*' + new string('|', n) + '*' + new string('/', n * 2 - 2) + '*');
                }
                else {
                    Console.WriteLine('*' + new string('/', n * 2 - 2) + '*' + new string(' ', n) + '*' + new string('/', n * 2 - 2) + '*');
                }                
            }

            //Footer
            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
        }
    }
}