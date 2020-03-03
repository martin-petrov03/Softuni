using System;
using WildFarm.Models.Animals;

namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Gosho", 45, "Bulgaria");
            dog.ProduceSound();
        }
    }
}
