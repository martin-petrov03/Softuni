using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomList(12);
            list.Add(10); list.Add(10); list.Add(2421421);
            list.ForEach(x => Console.WriteLine(x));            
        }
    }
}