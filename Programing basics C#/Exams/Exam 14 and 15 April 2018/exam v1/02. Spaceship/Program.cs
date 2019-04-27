using System;

namespace _2._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double peopleHeight = double.Parse(Console.ReadLine());

            double racketVolume = width * length * height;
            double roomVolume = (peopleHeight + 0.40) * 2 * 2;

            int countPeople = (int)Math.Floor(racketVolume / roomVolume);

            if (countPeople >= 3 && countPeople <= 10) {
                Console.WriteLine($"The spacecraft holds {countPeople} astronauts.");
            }
            else if (countPeople < 3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            else {
                Console.WriteLine($"The spacecraft is too big.");
            }
        }
    }
}
