using System;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Head
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();

            //Body
            
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("| ");                
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("- ");                    
                }
                Console.Write("|");
                Console.WriteLine();
            }            

            //Footer
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
        }
    }
}