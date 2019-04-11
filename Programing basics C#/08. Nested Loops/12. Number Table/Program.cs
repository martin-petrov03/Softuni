using System;

namespace _12.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                int left = row;
                int right = n - 1;
                for (int col = 1; col <= n; col++)
                {
                    if (left <= n)
                    {
                        Console.Write(left + " ");
                        left++;
                    }
                    else {
                        Console.Write(right + " ");
                        right--;
                    }                                           
                }
                Console.WriteLine();
            }
            
        }
    }
}