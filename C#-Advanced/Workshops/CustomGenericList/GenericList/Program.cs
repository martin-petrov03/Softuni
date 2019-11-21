using System;

namespace GenericList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();
            list.Add(654);
            Console.WriteLine(list.Count);
        }
    }
}