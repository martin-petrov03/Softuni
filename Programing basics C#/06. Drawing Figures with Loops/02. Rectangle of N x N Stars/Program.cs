using System;

namespace _02.Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int cols = 1; cols <= n; cols++)
            {
                for (int rows = 1; rows <= n; rows++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}