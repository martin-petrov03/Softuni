using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < line.Length; i++) {
                if (line[i] == '(')
                {
                    stack.Push(i);
                }
                else if (line[i] == ')') {
                    int index = stack.Pop();
                    Console.WriteLine(line.Substring(index, i - index + 1));
                }
            }
        }
    }
}
