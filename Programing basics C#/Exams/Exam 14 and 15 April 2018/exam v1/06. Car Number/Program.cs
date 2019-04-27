using System;

namespace _6._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            for (int num1 = from; num1 <= to; num1++)
            {
                for (int num2 = from; num2 <= to; num2++)
                {
                    for (int num3 = from; num3 <= to; num3++)
                    {
                        for (int num4 = from; num4 <= to; num4++)
                        {
                            if (((num2 + num3) % 2 == 0) && (num1 > num4)) {
                                if ((num1 % 2 == 0 && num4 % 2 != 0) || (num1 % 2 != 0 && num4 % 2 == 0)) {
                                    Console.Write($"{num1}{num2}{num3}{num4} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
