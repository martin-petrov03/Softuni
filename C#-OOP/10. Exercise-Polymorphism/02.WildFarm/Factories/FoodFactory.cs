using System;
using WildFarm.Models.Foods;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public Food CreateFood(string type, string[] foodArgs)
        {
            string foodType = type.ToLower();

            int quantity = int.Parse(foodArgs[0]);

            switch (foodType)
            {
                case "fruit":
                    return new Fruit(quantity);
                case "meat":
                    return new Meat(quantity);
                case "seeds":
                    return new Seeds(quantity);
                case "vegetable":
                    return new Vegetable(quantity);
                default:
                    throw new ArgumentException("Invalid food type!");
            }
        }
    }
}
