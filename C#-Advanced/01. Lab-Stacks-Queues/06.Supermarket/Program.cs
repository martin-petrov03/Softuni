using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string command = Console.ReadLine();
            int remainingPeople = 0;
            int totalPeople = 0;
            bool isPaid = false;
            while (command != "End")
            {
                if (command == "Paid")
                {
                    isPaid = true;
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    queue.Clear();
                    remainingPeople = 0;
                }
                else
                {                
                    queue.Enqueue(command); 
                    remainingPeople++;                   
                    totalPeople++;
                }
                command = Console.ReadLine();
            }
            if (!isPaid) {
                remainingPeople = totalPeople;                
            }
            
            Console.WriteLine($"{remainingPeople} people remaining.");
        }
    }
}
