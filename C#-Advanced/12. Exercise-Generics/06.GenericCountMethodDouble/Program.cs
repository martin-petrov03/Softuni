using System;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double doubleToCompare = double.Parse(Console.ReadLine());
            box.Compare(doubleToCompare);
            int result = box.CountGreater;

            Console.WriteLine(result);
        }
    }
}