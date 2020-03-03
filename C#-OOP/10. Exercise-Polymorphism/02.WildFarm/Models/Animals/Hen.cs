using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {        
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }  

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
