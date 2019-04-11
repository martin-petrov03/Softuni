using System;

namespace _06.Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());

            double counter = 0;
            for (int a = 0; a <= result; a++)
            {
                for (int b = 0; b <= result; b++)
                {
                    for (int c = 0; c <= result; c++)
                    {
                        for (int d = 0; d <= result; d++)
                        {
                            for (int e = 0; e <= result; e++)
                            {
                                if (a + b + c + d + e == result)
                                    counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}