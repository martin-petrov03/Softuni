using System;

namespace _02.Picture_in_the_Wall
{
    class Program
    {
        static void Main(string[] args)
        {
            int holeWidth = int.Parse(Console.ReadLine());
            int holeHeigth = int.Parse(Console.ReadLine());
            int picturesSides = int.Parse(Console.ReadLine());
            int countPictures = int.Parse(Console.ReadLine());

            int holeArea = holeWidth * holeHeigth;
            int picturesArea = picturesSides * picturesSides * countPictures;
            if(holeArea > picturesArea)
                Console.WriteLine($"The pictures fit in the hole. Hole area is {holeArea - picturesArea} bigger than pictures area.");
            else
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {picturesArea - holeArea} bigger than hole area.");
        }
    }
}
//start  -> 22:03
//end    -> 22:11