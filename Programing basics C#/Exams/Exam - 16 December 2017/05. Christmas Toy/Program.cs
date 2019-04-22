using System;

namespace _05.Christmas_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int weight = n * 5;

            Console.WriteLine(new string('-', (weight - n) / 2) + new string('*', n) + new string('-', (weight - n) / 2));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string('-', (weight - (2 * i + 2* i + n)) / 2) + new string('*', i) + new string('&', (n + 2*i)) + new string('*', i) + new string('-', (weight - (2 * i + 2 * i + n)) / 2));
            }

            for (int i = 1; i <= n / 2; i++)
            {                
                Console.WriteLine(
                   new string('-', (n - i)) +
                   new string('*', 2) +
                   new string('~', weight - (2 * (n - i) + 4)) +
                   new string('*', 2) +
                   new string('-', (n - i)));

            }
            //Middle
            Console.WriteLine(new string('-', n / 2) + new string('*', 1) + new string('|', weight - 2 - 2 * n/ 2) + new string('*', 1) + new string('-', n / 2));
                      
            for (int i = n/2; i >= 1; i--)
            {               
                Console.WriteLine(
                  new string('-', (n-i)) +
                  new string('*', 2) +
                  new string('~', (weight - (2 * (n - i) + 4))) +
                  new string('*', 2) +
                  new string('-', (n - i)));
            }            
            for (int i = n/2; i >= 1; i--)
            {                
                Console.WriteLine(new string('-', (weight - (2 * i + 2 * i + n)) / 2) + new string('*', i) + new string('&', (n + 2 * i)) + new string('*', i) + new string('-', (weight - (2 * i + 2 * i + n)) / 2));
            }

            Console.Write(new string('-', (weight - n) / 2));
            Console.Write(new string('*', n));
            Console.Write(new string('-', (weight - n) / 2));
            Console.WriteLine();
        }
    }
}