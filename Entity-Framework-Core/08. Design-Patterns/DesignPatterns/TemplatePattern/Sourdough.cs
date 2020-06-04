namespace TemplatePattern
{
    using System;

    class Sourdough : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering ingridients for Sourdough Bread!");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Sourdough Bread (20 minutes).");
        }
    }
}
