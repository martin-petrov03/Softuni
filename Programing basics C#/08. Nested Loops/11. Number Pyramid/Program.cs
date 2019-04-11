using System;

namespace _11.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int num = 1;

            while (num <= n)
            {
                for (int row = 1; row <= counter; row++)
                {
                    Console.Write(num + " ");
                    num++;
                    if (num > n)
                    {
                        break;
                    }
                }
                counter++;
                Console.WriteLine();
            }
        }
    }
}