using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> liquids = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Queue<int> liduidsQueue = new Queue<int>(liquids);

            List<int> physicalItems = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            //List<int> physicalItemsStack = new List<int>(physicalItems);
            Stack<int> physicalItemsStack = new Stack<int>(physicalItems);
            int glassCount = 0;
            int aluminiumCount = 0;
            int lithiumCount = 0;
            int carbonFiberCount = 0;

            while (liduidsQueue.Count > 0 && physicalItemsStack.Count > 0)
            {
                int currentLastPhysicalItem = physicalItemsStack.Pop();
                int sum = liduidsQueue.Dequeue() + currentLastPhysicalItem;

                string matirial = "";
                if (sum == 25)
                {
                    matirial = "Glass";
                    glassCount++;
                }
                else if (sum == 50)
                {
                    matirial = "Aluminium";
                    aluminiumCount++;
                }
                else if (sum == 75)
                {
                    matirial = "Lithium";
                    lithiumCount++;
                }
                else if (sum == 100)
                {
                    matirial = "Carbon fiber";
                    carbonFiberCount++;
                }

                if (matirial != "")
                {
                    //physicalItemsStack[physicalItemsStack.Count - 1] += 3;
                }
                else
                {
                    currentLastPhysicalItem += 3;
                    physicalItemsStack.Push(currentLastPhysicalItem);
                    //physicalItemsStack[physicalItemsStack.Count - 1] += 3;
                }

            }

            if (glassCount > 0 && aluminiumCount > 0 && lithiumCount > 0 && carbonFiberCount > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");

                if (liduidsQueue.Count > 0)
                {
                    Console.WriteLine($"Liquids left: {String.Join(", ", liduidsQueue)}");
                }
                else
                {
                    Console.WriteLine("Liquids left: none");
                }

                if (physicalItemsStack.Count > 0)
                {
                    
                    Console.WriteLine($"Physical items left: {String.Join(", ", physicalItemsStack)}");
                }
                else
                {
                    Console.WriteLine("Physical items left: none");
                }

                Console.WriteLine($"Aluminium: {aluminiumCount}");
                Console.WriteLine($"Carbon fiber: {carbonFiberCount}");
                Console.WriteLine($"Glass: {glassCount}");
                Console.WriteLine($"Lithium: {lithiumCount}");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");

                if (liduidsQueue.Count > 0)
                {
                    Console.WriteLine($"Liquids left: {String.Join(", ", liduidsQueue)}");
                }
                else
                {
                    Console.WriteLine("Liquids left: none");
                }

                if (physicalItemsStack.Count > 0)
                {
                    
                    Console.WriteLine($"Physical items left: {String.Join(", ", physicalItemsStack)}");
                }
                else
                {
                    Console.WriteLine("Physical items left: none");
                }

                Console.WriteLine($"Aluminium: {aluminiumCount}");
                Console.WriteLine($"Carbon fiber: {carbonFiberCount}");
                Console.WriteLine($"Glass: {glassCount}");
                Console.WriteLine($"Lithium: {lithiumCount}");
            }
        }
    }
}