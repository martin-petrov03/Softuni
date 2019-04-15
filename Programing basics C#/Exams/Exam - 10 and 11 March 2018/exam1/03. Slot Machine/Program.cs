using System;

namespace _03.Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            int firstNum = int.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            

            int firstSumAsciiValue = firstSymbol + firstNum;
            int secondSumAsciiValue = secondSymbol + secondNum;
            int thirdSumAsciiValue = thirdSymbol + thirdNum;

            char first = (char)firstSumAsciiValue;
            char second = (char)secondSumAsciiValue;
            char third = (char)thirdSumAsciiValue;

            string result = first.ToString() + second.ToString() + third.ToString();
            if (result == "@@@")
            {
                Console.WriteLine("@@@");
                Console.WriteLine($"!!! YOU LOSE EVERYTHING !!!");
            }
            else if (result == "777")
            {
                Console.WriteLine("777");
                Console.WriteLine($"*** JACKPOT ***");
            }
            else
                Console.WriteLine($"{first}{second}{third}");

        }
    }
}
//start  -> 22:11
//break ->22:26  --->> 22:30
//end    -> 22:36