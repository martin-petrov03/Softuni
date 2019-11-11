using System;

namespace GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);
            }

            string result = box.ToString();
            Console.WriteLine(result);
        }
    }
}