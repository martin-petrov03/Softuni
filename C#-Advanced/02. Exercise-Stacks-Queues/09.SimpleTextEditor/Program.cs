using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Stack <string> stackOfText = new Stack<string>();
            string text = String.Empty;

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "1")
                {
                    stackOfText.Push(text);
                    text += line[1];

                }
                else if (line[0] == "2")
                {
                    int index = int.Parse(line[1]);
                    stackOfText.Push(text);
                    text = text.Substring(0, text.Length - index);
                }
                else if (line[0] == "3")
                {
                    int index = int.Parse(line[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (line[0] == "4")
                {
                    text = stackOfText.Pop();
                }
            }
        }
    }
}
