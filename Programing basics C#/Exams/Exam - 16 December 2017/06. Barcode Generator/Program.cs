using System;

namespace _06.Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int iStrart = num1 / 1000;
            int jStart = num1 / 100 % 10;
            int kStart = num1 / 10 % 10;
            int mStart = num1 % 10;

            int iEnd = num2 / 1000;
            int jEnd = num2 / 100 % 10;
            int kEnd = num2 / 10 % 10;
            int mEnd = num2 % 10;
            for (int i = iStrart; i <= iEnd; i++)
            {
                for (int j = jStart; j <= jEnd; j++)
                {
                    for (int k = kStart; k <= kEnd; k++)
                    {
                        for (int m = mStart; m <= mEnd; m++)
                        {
                            if((i % 2 != 0) && (j % 2 != 0) && (k % 2 != 0) && (m % 2 != 0)){  
                                   Console.Write($"{i}{j}{k}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}