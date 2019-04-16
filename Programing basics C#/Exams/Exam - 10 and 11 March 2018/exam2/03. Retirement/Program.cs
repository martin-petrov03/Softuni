using System;

namespace _03.Retirement
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int internship = int.Parse(Console.ReadLine());

            int countInvalidInput = 0;
            if (sex == "male")
            {
                if (age >= 64 && internship >= 38)
                {
                    Console.WriteLine($"Ready to retire at {age} and {internship} years of experience!");
                }
                else if (age < 64 && internship >= 38)
                {
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {64 - age}.");
                }
                else if (age >= 64 && internship < 38)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {38 - internship}.");
                }
                else if (age < 64 && internship < 38)
                {
                    Console.WriteLine($"Too early. Years left to retirement: {64 - age}. Work experience left to retirement: {38 - internship}.");
                }
                else
                {
                    countInvalidInput++;
                }
            }
            else if (sex == "female")
            {
                if (age >= 61 && internship >= 35)
                {
                    Console.WriteLine($"Ready to retire at {age} and {internship} years of experience!");
                }
                else if (age < 61 && internship >= 35)
                {
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {61 - age}.");
                }
                else if (age >= 61 && internship < 35)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {35 - internship}.");
                }
                else if(age < 61 && internship < 35) {
                    Console.WriteLine($"Too early. Years left to retirement: {61 - age}. Work experience left to retirement: {35 - internship}.");
                }
                else
                {
                    countInvalidInput++;
                }                    
            }
            else {
                countInvalidInput++;
            }

            if(countInvalidInput > 0)
                Console.WriteLine($"Invalid input.");
        }
    }
}
//start  ->  10:38
//end  ->  10:53