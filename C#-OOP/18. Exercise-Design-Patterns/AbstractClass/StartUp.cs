using System;

namespace AbstractClass
{
    class StartUp
    {
        static void Main()
        {
            SandwichMenu sandwichMenu = new SandwichMenu();

            sandwichMenu["4th July"] = new Sandwich("Beef", "Cheddar", "White", "Cucumber");

            Sandwich sandwich = sandwichMenu["4th July"];
            Sandwich sandwichCopy = sandwich.Clone();
        }
    }
}
