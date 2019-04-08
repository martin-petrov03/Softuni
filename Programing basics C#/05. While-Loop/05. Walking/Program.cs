using System;

namespace _05.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int purpose = 10_000;
            int stepsSum = 0;
            string output = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    int finalSteps = int.Parse(Console.ReadLine());
                    stepsSum += finalSteps;
                    break;
                }
                else
                {
                    int currentSteps = int.Parse(command);
                    stepsSum += currentSteps;

                    if (stepsSum >= purpose)
                        break;
                }
            }
            if (stepsSum >= purpose)
                output = "Goal reached! Good job!";
            else
                output = $"{purpose - stepsSum} more steps to reach goal.";
            Console.WriteLine(output);
        }
    }
}