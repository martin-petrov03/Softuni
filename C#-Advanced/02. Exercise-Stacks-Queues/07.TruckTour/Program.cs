using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            Queue<int[]> petrolPumps = new Queue<int[]>();

            int fuel = 0;
            for (int i = 0; i < n; i++) {
                int[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolPumps.Enqueue(line);                
            }

            int index = 0;
            while (true) {
                int totalFuel = 0;

                foreach (int[] petrolPump in petrolPumps)
                {
                    int amountPetrol = petrolPump[0];
                    int distanceToNext = petrolPump[1];                    

                    totalFuel += amountPetrol - distanceToNext;

                    if (totalFuel < 0) {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totalFuel >= 0) {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
