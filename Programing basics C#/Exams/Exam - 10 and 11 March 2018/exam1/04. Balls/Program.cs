using System;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsCount = int.Parse(Console.ReadLine());


            int points = 0;

            int redBallsCounter = 0;
            int orangeBallsCounter = 0;
            int yellowBallsCounter = 0;
            int whiteBallsCounter = 0;
            int blackBallsCounter = 0;
            int otherColorsBallsCounter = 0;
            for (int i = 1; i <= ballsCount; i++)
            {
                string currentColor = Console.ReadLine();
                if (currentColor == "red")
                {
                    points += 5;
                    redBallsCounter++;
                }
                else if (currentColor == "orange")
                {
                    points += 10;
                    orangeBallsCounter++;
                }
                else if (currentColor == "yellow")
                {
                    points += 15;
                    yellowBallsCounter++;
                }
                else if (currentColor == "white")
                {
                    points += 20;
                    whiteBallsCounter++;
                }
                else if (currentColor == "black")
                {
                    points /= 2;
                    blackBallsCounter++;
                }
                else {
                    otherColorsBallsCounter++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {redBallsCounter}");
            Console.WriteLine($"Points from orange balls: {orangeBallsCounter}");
            Console.WriteLine($"Points from yellow balls: {yellowBallsCounter}");
            Console.WriteLine($"Points from white balls: {whiteBallsCounter}");
            Console.WriteLine($"Other colors picked: {otherColorsBallsCounter}");
            Console.WriteLine($"Divides from black balls: {blackBallsCounter}");
        }
    }
}

//start  -> 7:10
//break ->   --->> 
//end    -> 7:22