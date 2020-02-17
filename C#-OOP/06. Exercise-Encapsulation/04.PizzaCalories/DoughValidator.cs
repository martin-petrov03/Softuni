using System.Collections.Generic;

namespace PizzaCalories
{
    public static class DoughValidator
    {
        private static Dictionary<string, double> flourTypes;
        private static Dictionary<string, double> bakingTechniques;
        
        public static bool IsValidFlourType(string type)
        {
            if (flourTypes == null || bakingTechniques == null)
            {
                Initializa();
            }

            return flourTypes.ContainsKey(type.ToLower());
        }        

        public static bool IsValidBackingTechnique(string type)
        {
            Initializa();
            return bakingTechniques.ContainsKey(type.ToLower());
        }

        public static double GetFlourModifier(string type)
        {
            Initializa();
            return flourTypes[type.ToLower()];
        }

        public static double GetBackingTechniqueModifier(string type)
        {
            Initializa();
            return bakingTechniques[type.ToLower()];
        }

        private static void Initializa()
        {
            if (flourTypes == null || bakingTechniques == null)
            {                
                flourTypes = new Dictionary<string, double>();
                bakingTechniques = new Dictionary<string, double>();

                flourTypes.Add("white", 1.5);
                flourTypes.Add("wholegrain", 1);

                bakingTechniques.Add("crispy", 0.9);
                bakingTechniques.Add("chewy", 1.1);
                bakingTechniques.Add("homemade", 1);
            }
        }
    }
}
