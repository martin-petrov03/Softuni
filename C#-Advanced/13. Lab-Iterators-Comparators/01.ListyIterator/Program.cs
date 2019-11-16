using System;
using System.Linq;
using System.Collections.Generic;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string[] line = Console.ReadLine()
                .Split();
            
            while (line[0] != "END")
            {
                try
                {
                    if (line[0] == "Create")
                    {
                        List<string> items = line.Skip(1).ToList();
                        listyIterator = new ListyIterator<string>(items);
                    }
                    else if (line[0] == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (line[0] == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (line[0] == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
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