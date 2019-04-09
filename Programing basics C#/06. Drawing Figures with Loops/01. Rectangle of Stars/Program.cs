using System;

namespace Rectangle_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cols = 1; cols <= 10; cols++)
            {
                for (int rows = 1; rows <= 10; rows++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}