using System;

namespace _02._Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char sex = char.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string typeActivity = Console.ReadLine();

            double multiplier = 0;
            double BMH = 0;

            if (typeActivity == "sedentary")
            {
                multiplier = 1.2;
            }
            else if (typeActivity == "lightly active")
            {
                multiplier = 1.375;
            }
            else if (typeActivity == "moderately active")
            {
                multiplier = 1.55;
            }
            else if (typeActivity == "very active")
            {
                multiplier = 1.725;
            }

            if (sex == 'm')
            {
                //БНМ = 66 + (13,7 x тегло в килограми) + (5 x височина в сантиметри) - (6,8 x възрастта в години)
                BMH = 66 + (13.7 * weight) + (5 * height * 100) - (6.8 * age) ;
            }
            else if(sex == 'f'){
                //БНМ = 655 + (9,6 x тегло в килограми) + (1,8 x височина в сантиметри) - (4,7 x възрастта в години)
                BMH = 655 + (9.6 * weight) + (1.8 * height * 100) - (4.7 * age);
            }
            double sum = (int)Math.Ceiling(BMH * multiplier);            
            Console.WriteLine($"To maintain your current weight you will need {sum} calories per day.");
        }
    }
}
