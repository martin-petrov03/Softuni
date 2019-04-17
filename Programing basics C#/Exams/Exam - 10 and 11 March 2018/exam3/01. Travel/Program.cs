using System;

namespace _01._Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double aToBKm = double.Parse(Console.ReadLine());
            double truckSpeed = double.Parse(Console.ReadLine());
            double truckMinusAutoSpeed = double.Parse(Console.ReadLine());

           double autoSpeed = truckSpeed + truckMinusAutoSpeed * 3.6;
            //autoSpeed *= 3.6;

            double truckTime = Math.Ceiling(aToBKm / truckSpeed);
            double autoTime = Math.Ceiling(aToBKm / autoSpeed);
            Console.WriteLine($"The truck arrived after {truckTime} hours");
            Console.WriteLine($"The car arrived after {autoTime} hours");
        }
    }
}
// start -> 4:50