using System;

namespace _03._Online_Education
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inpuut
            string earlySessionEqducationType = Console.ReadLine();
            int earlySessionStuddentsCount = int.Parse(Console.ReadLine());
            string normalSessionEqducationType = Console.ReadLine();
            int normalSessionStuddentsCount = int.Parse(Console.ReadLine());
            string laterSessionEqducationType = Console.ReadLine();
            int laterSessionStuddentsCount = int.Parse(Console.ReadLine());

            int totalStudentsOnsite = 0; 
            int totalStudentsOnline = 0;

            //Early Session
            if (earlySessionEqducationType == "onsite")
            {
                totalStudentsOnsite += earlySessionStuddentsCount;
            }
            else if (earlySessionEqducationType == "online") {
                totalStudentsOnline += earlySessionStuddentsCount;
            }

            // Normal Seesion
            if (normalSessionEqducationType == "onsite")
            {
                totalStudentsOnsite += normalSessionStuddentsCount;
            }
            else if (normalSessionEqducationType == "online")
            {
                totalStudentsOnline += normalSessionStuddentsCount;
            }

            // Late Session
            if (laterSessionEqducationType == "onsite")
            {
                totalStudentsOnsite += laterSessionStuddentsCount;
            }
            else if (laterSessionEqducationType == "online")
            {
                totalStudentsOnline += laterSessionStuddentsCount;
            }

            // Is Hall Full
            if (totalStudentsOnsite > 600) {
                totalStudentsOnline += totalStudentsOnsite - 600;
                totalStudentsOnsite -= totalStudentsOnsite - 600;
            }
            
            // Output
            Console.WriteLine($"Online students: {totalStudentsOnline}");
            Console.WriteLine($"Onsite students: {totalStudentsOnsite}");
            Console.WriteLine($"Total students: {totalStudentsOnline + totalStudentsOnsite}");
        }
    }
}
