using System;

namespace _06._Magical_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            for (int p = 1; p <= 9; p++)
                            {
                                for (int o = 1; o <= 9; o++)
                                {
                                    if (i * j * k * m * p * o == num) {
                                        Console.Write($"{i}{j}{k}{m}{p}{o} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
