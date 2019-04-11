using System;

namespace _03.Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int powOfTwo = 0;
            for (int i = 0; i <= num; i += 2)
            {
                powOfTwo = i;
                Console.WriteLine(Math.Pow(2, powOfTwo));
            }
        }
    }
}