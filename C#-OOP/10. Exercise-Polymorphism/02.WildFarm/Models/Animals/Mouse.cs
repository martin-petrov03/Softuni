using System;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
