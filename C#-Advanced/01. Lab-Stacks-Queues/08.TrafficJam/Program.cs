using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int numberCarsAtGreen = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int count = 0;
            while (command.ToLower() != "end") {
                if (command.ToLower() == "green")
                {
                    int currentCount = queue.Count > numberCarsAtGreen ? numberCarsAtGreen : queue.Count;
                    for (int i = 0; i < currentCount; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                }
                else {                
                    queue.Enqueue(command);                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
