using System;

namespace _06._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            int counter = 0;
            for (char i = a; i <= b; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char k = a; k <= b; k++)
                    {
                        if (i != c && j != c && k != c)
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.Write("{0}", counter);
        }
    }
}
