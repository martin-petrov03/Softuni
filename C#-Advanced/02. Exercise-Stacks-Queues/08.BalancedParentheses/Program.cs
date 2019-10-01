using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line = Console.ReadLine()
                .ToCharArray();
            Stack<char> stack = new Stack<char>();
            char[] openParenetheses = new char[] { '(', '[', '{' };

            bool isValid = true;            
            foreach(char item in line)
            {            
                if (openParenetheses.Contains(item)) {
                    stack.Push(item);
                    continue;
                }

                if(stack.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stack.Peek() == '(' && item == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && item == ']')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '{' && item == '}')
                {
                    stack.Pop();
                }
                else {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
