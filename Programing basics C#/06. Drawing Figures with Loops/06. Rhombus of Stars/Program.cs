using System;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            // Upper Part 
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }                 
                Console.Write(new string(' ', n - i));
                Console.WriteLine();
            }
            // Bottom Part
          
            for (int i = n - 1; i >= 1; i--)
            {                
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(new string(' ', n - i));
                Console.WriteLine();
            }
        }
    }
}