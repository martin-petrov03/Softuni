namespace PrototypePattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SandwichMenu sandwichMenu = new SandwichMenu();

            sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomatoes");

            sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Bacon", "", "Tomatoes");

            Sandwich bltSandwich = sandwichMenu["BLT"].Clone() as Sandwich;
        }
    }
}
