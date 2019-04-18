using System;

namespace _03._Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string catBreed = Console.ReadLine();
            char sex = char.Parse(Console.ReadLine());

            bool isRealCatBreed = true;
            double months = 2;
            if (sex == 'm')
            {
                if (catBreed == "British Shorthair")
                {
                    months *= 13;
                }
                else if (catBreed == "Siamese")
                {
                    months *= 15;
                }
                else if (catBreed == "Persian")
                {
                    months *= 14;
                }
                else if (catBreed == "Ragdoll")
                {
                    months *= 16;
                }
                else if (catBreed == "American Shorthair")
                {
                    months *= 12;
                }
                else if (catBreed == "Siberian")
                {
                    months *= 11;
                }
                else {
                    isRealCatBreed = false;
                }
            }
            else if (sex == 'f')
            {
                if (catBreed == "British Shorthair")
                {
                    months *= 14;
                }
                else if (catBreed == "Siamese")
                {
                    months *= 16;
                }
                else if (catBreed == "Persian")
                {
                    months *= 15;
                }
                else if (catBreed == "Ragdoll")
                {
                    months *= 17;
                }
                else if (catBreed == "American Shorthair")
                {
                    months *= 13;
                }
                else if (catBreed == "Siberian")
                {
                    months *= 12;
                }
                else
                {
                    isRealCatBreed = false;
                }
            }
            else
            {
                isRealCatBreed = false;
            }

            if (!isRealCatBreed)
            {
                Console.WriteLine($"{catBreed} is invalid cat!");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(months)} cat months");
            }
        }
    }
}
