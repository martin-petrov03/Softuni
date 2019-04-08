using System;

namespace _07.Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int glassVolume = int.Parse(Console.ReadLine());
            int tapp = 0;
            while (true) {
                string command = Console.ReadLine();
                if (command == "Easy")
                {
                    tapp++;
                    glassVolume -= 50;
                } else if (command == "Medium") {
                    tapp++;
                    glassVolume -= 100;
                } else if (command == "Hard") {
                    tapp++;
                    glassVolume -= 200;
                }
                if (glassVolume <= 0) { break; }
            }
            if (glassVolume == 0)
            {
                Console.WriteLine($"The dispenser has been tapped {tapp} times.");
            }
            else {
                Console.WriteLine($"{0 - glassVolume}ml has been spilled.");
            }
        }
    }
}