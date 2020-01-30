using System;

namespace CustomStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(new[] { "1", "2", "4" });
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
