using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(). Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(line);

            int sum = 0;
            int countRacks = 1;
            while (stack.Count > 0)
            {
                sum += stack.Peek();
                
                //check is it full
                if (sum <= capacity)
                {
                    stack.Pop();
                }
                else
                {
                    countRacks++;
                    sum = 0;
                }
            }
            Console.WriteLine(countRacks);
        }
    }
}
