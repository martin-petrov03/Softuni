using System;

namespace GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            string stringToCompare = Console.ReadLine();
            box.Compare(stringToCompare);
            int result = box.CountGreater;

            Console.WriteLine(result);
        }
    }
}