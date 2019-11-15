using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split();

            string personName = personInfo[0] + " " + personInfo[1];
            string personTown = personInfo[2];

            string[] personBeerInfo = Console.ReadLine()
                .Split();

            string[] numbers = Console.ReadLine()
                .Split();

            int integer = int.Parse(numbers[0]);
            double d = double.Parse(numbers[1]);

            

            Tuple<string, string> personTyple = new Tuple<string, string>(personName, personTown);
            Tuple<string, int> personBeerTyple = new Tuple<string, int>(personBeerInfo[0], int.Parse(personBeerInfo[1]));
            Tuple<int, double> numbersTyple = new Tuple<int, double>(integer, d);

            Console.WriteLine(personTyple.GetInfo());
            Console.WriteLine(personBeerTyple.GetInfo());
            Console.WriteLine(numbersTyple.GetInfo());
        }
    }
}