using System;

namespace _02.Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            int powerOfOneOfAll = int.Parse(Console.ReadLine());
            int healthOfIlindan = int.Parse(Console.ReadLine());

            int totalPower = countPeople * powerOfOneOfAll;
            if(totalPower > healthOfIlindan)
                Console.WriteLine($"Illidan has been slain! You defeated him with {totalPower - healthOfIlindan} points.");
            else if(totalPower < healthOfIlindan)
                Console.WriteLine($"You are not prepared! You need {healthOfIlindan - totalPower} more points.");
        }        
    }
}
//start  ->  10:32
//end  ->  10:38