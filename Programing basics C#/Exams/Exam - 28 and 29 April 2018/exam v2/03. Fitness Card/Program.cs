using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double charge = 0;
            if (sex == 'm')
            {
                if (sport == "Gym") {
                    charge = 42;
                }
                else if (sport == "Boxing")
                {
                    charge = 41;
                }
                else if (sport == "Yoga")
                {
                    charge = 45;
                }
                else if (sport == "Zumba")
                {
                    charge = 34;
                }
                else if (sport == "Dances")
                {
                    charge = 51;
                }
                else if (sport == "Pilates")
                {
                    charge = 39;
                }                
            }
            else if (sex == 'f') {
                if (sport == "Gym")
                {
                    charge = 35;
                }
                else if (sport == "Boxing")
                {
                    charge = 37;
                }
                else if (sport == "Yoga")
                {
                    charge = 42;
                }
                else if (sport == "Zumba")
                {
                    charge = 31;
                }
                else if (sport == "Dances")
                {
                    charge = 53;
                }
                else if (sport == "Pilates")
                {
                    charge = 37;
                }
            }

            if (age <= 19) {
                charge -= charge * 20 / 100;
            }

            if (budget >= charge)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else {
                Console.WriteLine($"You don't have enough money! You need ${(charge - budget):F2} more.");
            }
        }
    }
}
