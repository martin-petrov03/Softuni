using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        arr = Add(arr);                        
                        break;
                    case "multiply":
                        arr = Multiply(arr);                        
                        break;
                    case "subtract":
                        arr = Subtract(arr);                        
                        break;
                    case "print":
                        Print(arr);
                        break;                    
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }

        static List<int> Add(List<int> arr)
        {            
            return arr.Select(e => e+1).ToList();
        }

        static List<int> Multiply(List<int> arr)
        {
            return arr.Select(e => e * 2).ToList();
        }

        static List<int> Subtract(List<int> arr)
        {
            return arr.Select(e => e - 1).ToList();
        }

        static void Print(List<int> arr)
        {
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}