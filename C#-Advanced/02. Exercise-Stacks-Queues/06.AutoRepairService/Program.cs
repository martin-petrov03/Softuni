using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.AutoRepairService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carModels = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] command = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> servedCars = new Stack<string>();
            Queue<string> waitingCars = new Queue<string>(carModels);

            while (command[0] != "End") {
                if (command[0] == "Service")
                {
                    if (waitingCars.Count > 0)
                    {
                        string currentCar = waitingCars.Dequeue();
                        
                        servedCars.Push(currentCar);
                        Console.WriteLine($"Vehicle {currentCar} got served.");
                    }
                }
                else if (command[0] == "CarInfo")
                {
                    string car = command[1];                    
                    if (waitingCars.Contains(car))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command[0] == "History") {
                    Console.WriteLine(String.Join(", ", servedCars));
                }

                command = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
            }
            if (waitingCars.Count > 0)
            {
                Console.WriteLine("Vehicles for service: " + String.Join(", ", waitingCars));
            }
            Console.WriteLine("Served vehicles: " + String.Join(", ", servedCars));
        }
    }
}
