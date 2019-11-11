using System;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            string result = box.ToString();
            Console.WriteLine(result); ;
        }
    }
}