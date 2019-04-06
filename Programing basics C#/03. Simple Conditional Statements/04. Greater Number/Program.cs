using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine($"Greater number: {num1}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Greater number: {num2}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}