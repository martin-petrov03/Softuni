using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Collection<string> collection = null;

            string[] line = Console.ReadLine()
                .Split();

            while (line[0] != "END")
            {
                try
                {
                    if (line[0] == "Create")
                    {
                        List<string> items = line.Skip(1).ToList();
                        collection = new Collection<string>(items);
                    }
                    else if (line[0] == "Print")
                    {
                        collection.Print();
                    }
                    else if (line[0] == "Move")
                    {
                        Console.WriteLine(collection.Move());
                    }
                    else if (line[0] == "HasNext")
                    {
                        Console.WriteLine(collection.HasNext());
                    }
                    else if (line[0] == "PrintAll")
                    {
                        foreach (var item in collection)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Operation!");
                }

                line = Console.ReadLine()
                    .Split();
            }
        }
    }
}