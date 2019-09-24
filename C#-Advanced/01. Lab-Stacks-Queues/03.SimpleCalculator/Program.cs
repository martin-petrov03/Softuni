using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(line.Reverse());

            while (stack.Count > 1)
            {
                int opr1 = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int opr2 = int.Parse(stack.Pop());

                switch (opr)
                {
                    case "+":
                        stack.Push($"{opr1 + opr2}");                  
                        break;
                    case "-":
                        stack.Push($"{opr1 - opr2}");
                        break;
                    default:
                        //Console.WriteLine("Invalid Command!");
                        break;
                }
            }
                      
            
            foreach(string item in stack) {
                Console.WriteLine(item);
            }
        }
    }
}