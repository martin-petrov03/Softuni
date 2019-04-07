using System;

namespace _09.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string dayWithWords = "";
            switch (day) {
                case 1:
                    dayWithWords = "Monday";
                    break;
                case 2:
                    dayWithWords = "Tuesday";
                    break;
                case 3:
                    dayWithWords = "Wednesday";
                    break;
                case 4:
                    dayWithWords = "Thursday";
                    break;
                case 5:
                    dayWithWords = "Friday";
                    break;
                case 6:
                    dayWithWords = "Saturday";
                    break;
                case 7:
                    dayWithWords = "Sunday";
                    break;                
                default:
                    dayWithWords = "Error";
                    break;
            }
            Console.WriteLine(dayWithWords);
        }
    }
}