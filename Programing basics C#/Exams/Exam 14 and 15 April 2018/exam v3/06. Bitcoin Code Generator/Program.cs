using System;

namespace _6._Bitcoin_Code_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxCount = int.Parse(Console.ReadLine());

            char i = (char)32;
            char j = (char)57;

            int count = 0;
            for (int k = 1; k <= a; k++)
            {
                for (int l = 1; l <= b; l++)
                {
                    i++;
                    j++;
                    if (i > 47) i = (char)33;
                    if (j > 64) j = (char)58;
                    count++;
                    //System.out.printf("%s%s%s%s%s%s|", i, j, k, l, j, i);
                    Console.Write($"{i}{j}{k}{l}{j}{i}|");
                    if (count == maxCount) return;

                }
            }

        }
    }
}
