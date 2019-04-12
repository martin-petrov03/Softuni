using System;

namespace p06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            if (n < 10)
            {
                i = n;
            }
            else {
                i = 10;
            }
                for (int a = 1; a < i; a++)
                {
                    for (int b = 1; b < i; b++)
                    {
                        for (int c = 1; c < i; c++)
                        {
                            for (int d = 1; d < i; d++)
                            {
                               if ((a + b) == (c + d) && n % (a + b) == 0)
                               {
                                   Console.Write(a); Console.Write(b); Console.Write(c); Console.Write(d + " ");
                               }
                            }
                        }
                    }
                }
        }
    }
}