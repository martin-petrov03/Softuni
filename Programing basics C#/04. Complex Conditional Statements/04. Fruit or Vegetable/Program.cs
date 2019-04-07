using System;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (input == "carrot" || input == "pepper" || input == "cucumber" || input == "tomato")
            {
                Console.WriteLine("vegetable");
            }
            else {
                Console.WriteLine("unknown");
            }
        }
    }
}