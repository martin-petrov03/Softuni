using System;

namespace _06._Bank_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
                   
            int combinationsCounter = 0;
            for (int i = a; i <= 99; i++)
            {
                if (i % 10 == 2)
                {
                    for (char j = b; j <= 'Z'; j++)
                    {
                        for (char k = c; k <= 'z'; k++)
                        {
                            for (char m = d; m <= 'Z'; m++)
                            {
                                for (int p = e; p >= 10; p--)
                                {
                                    if (i % 10 == 2 && p % 10 == 5)
                                    {                               
                                        combinationsCounter++;
                                        if (combinationsCounter == N)
                                        {
                                            Console.WriteLine($"{i}{j}{k}{m}{p}");
                                            break;
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
}
