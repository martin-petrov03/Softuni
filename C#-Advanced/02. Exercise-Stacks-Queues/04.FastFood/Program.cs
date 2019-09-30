using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> leftOrder = new Queue<int>(line);

            Console.WriteLine(line.Max());
            int i = 0;
            while (leftOrder.Count > 0) {
                
                if (foodQuantity - line[i] >= 0)
                {
                   leftOrder.Dequeue();
                   foodQuantity -= line[i];
                }
                else
                {
                    break;
                }
                i++;
            }
            if (leftOrder.Count > 0)
            {
                Console.WriteLine($"Orders left: {String.Join(" ", leftOrder)}");
            }
            else {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
