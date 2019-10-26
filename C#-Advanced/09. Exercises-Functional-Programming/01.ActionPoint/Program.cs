using System;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names =>
            Console.WriteLine(String.Join(Environment.NewLine, names));

            string[] inputNames = Console.ReadLine()
                .Split();
            printNames(inputNames);            
        }
    }
}