using System;

namespace _06._stypidPasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++) {
                    for (char a = (char)97; a < 97 + l; a++)
                    {
                        for (char b = (char)97; b < 97 + l; b++)
                        {
                            for (int c = 1; c <= n; c++)
                            {
                                if (a < 122 && b < 122 && c > i && c > j) {
                                    Console.Write($"{i}{j}{a}{b}{c} "); 
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
// start -> 4:50
// end -> 