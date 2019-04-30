using System;

namespace _03._Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string breed = Console.ReadLine();
            char sex = char.Parse(Console.ReadLine());

            bool isInvalidBreed = false;
            int catsMonthsLife = 2;
            if (sex == 'm')
            {
                if (breed == "British Shorthair")
                {
                    catsMonthsLife *= 13;
                }
                else if (breed == "Siamese")
                {
                    catsMonthsLife *= 15;
                }
                else if (breed == "Persian")
                {
                    catsMonthsLife *= 14;
                }
                else if (breed == "Ragdoll")
                {
                    catsMonthsLife *= 16;
                }
                else if (breed == "American Shorthair")
                {
                    catsMonthsLife *= 12;
                }
                else if (breed == "Siberian")
                {
                    catsMonthsLife *= 11;
                }
                else
                {
                    isInvalidBreed = true;
                }
            }
            else if (sex == 'f')
            {
                if (breed == "British Shorthair")
                {
                    catsMonthsLife *= 14;
                }
                else if (breed == "Siamese")
                {
                    catsMonthsLife *= 16;
                }
                else if (breed == "Persian")
                {
                    catsMonthsLife *= 15;
                }
                else if (breed == "Ragdoll")
                {
                    catsMonthsLife *= 17;
                }
                else if (breed == "American Shorthair")
                {
                    catsMonthsLife *= 13;
                }
                else if (breed == "Siberian")
                {
                    catsMonthsLife *= 12;
                }
                else
                {
                    isInvalidBreed = true;
                }
            }
            else
            {
                isInvalidBreed = true;
            }            

            if (isInvalidBreed)
            {
                Console.WriteLine($"{breed} is invalid cat!");
            }
            else
            {
                Console.WriteLine($"{catsMonthsLife} cat months");
            }
        }
    }
}
