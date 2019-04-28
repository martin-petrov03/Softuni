using System;

namespace _4._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceheight = int.Parse(Console.ReadLine());
            string command;

            int freeSpaceVolume = freeSpaceheight * freeSpaceLength * freeSpaceWidth;
            int boxVolume = 0;
            bool notEnoughtSpace = false;

            while (true)
            {
                command = Console.ReadLine();                
                if (command == "Done") {
                    break;
                }
                int currentCountBoxes = int.Parse(command);
                boxVolume += currentCountBoxes;
                if (boxVolume > freeSpaceVolume)
                {
                    notEnoughtSpace = true;
                    break;
                }
            }

            if (notEnoughtSpace)
            {
                Console.WriteLine($"No more free space! You need {boxVolume - freeSpaceVolume} Cubic meters more.");
            }
            else {
                Console.WriteLine($"{freeSpaceVolume - boxVolume} Cubic meters left.");
            }
        }
    }
}
