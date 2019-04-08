using System;

namespace _08.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int i = 1;
            Console.WriteLine(i);
            while (true) {
                int result = 2 * i + 1;
                if (result <= inputNum)
                {
                    Console.WriteLine(result);
                }
                else {
                    break;
                }
                i = result;
            }
        }
    }
}