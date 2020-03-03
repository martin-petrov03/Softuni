using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten;

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }


        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }

        public abstract void ProduceSound();        
    }
}
