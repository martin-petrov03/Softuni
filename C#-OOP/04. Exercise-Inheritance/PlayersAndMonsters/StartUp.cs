using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Hero gosho = new BladeKnight("Gosho", 12);
            Hero pesho = new DarkWizard("Pesho", 12);

            Console.WriteLine(gosho);
            Console.WriteLine(pesho);
        }
    }
}