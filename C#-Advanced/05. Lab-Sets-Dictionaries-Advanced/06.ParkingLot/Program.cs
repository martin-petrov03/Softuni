using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (line[0] != "END")
            {
                if (line[0] == "IN")
                {
                    cars.Add(line[1]);
                }
                else if (line[0] == "OUT")
                {
                    cars.Remove(line[1]);
                }

                line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}