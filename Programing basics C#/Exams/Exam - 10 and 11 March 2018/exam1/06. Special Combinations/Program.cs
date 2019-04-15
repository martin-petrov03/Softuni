using System;

namespace _06.Special_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 2; i <= a; i++)
            {
                for (int j = 2; j <= b; j++)
                {
                    for (int k = 2; k <= c; k++)
                    {
                        if ((i % 2 == 0) && isPrime(j) && (k % 2 == 0)) {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
        static bool isPrime(int a) {
            bool isPrime = true;
            for (int i = a; i >= 1; i--)
            {
                if (i == a || i == 1)
                {
                    continue;
                }
                else if (a % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
//start  -> 7:22
//break ->   --->> 7:37
//end    -> 