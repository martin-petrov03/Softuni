using System;

namespace _6_PairPrimes
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int num1To = int.Parse(Console.ReadLine());
            int num2To = int.Parse(Console.ReadLine());

            for (int n = num1; n <= num1 + num1To; n++)
            {
                for (int m = num2; m <= num2 + num2To; m++)
                {
                    if (isPrime(n) && isPrime(m))
                    {
                        Console.WriteLine($"{n}{m}");
                    }

                }
            }
        }
        static bool isPrime(int a)
        {
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