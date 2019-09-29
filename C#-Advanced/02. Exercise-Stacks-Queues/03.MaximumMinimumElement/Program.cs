using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MaximumMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int numberLines = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberLines; i++) {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int command = line[0];                       

                switch (command)
                {
                    case 1:
                        if (line.Length > 1)
                        {
                            int element = line[1];
                            stack.Push(element);
                        }
                        break;
                    case 2:
                        if (stack.Count > 0) {
                            stack.Pop();                        
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {                         
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {                         
                            Console.WriteLine(stack.Min());
                        }
                        break;                   
                }                
            }
            Console.Write(String.Join(", ", stack));            
        }
    }
}