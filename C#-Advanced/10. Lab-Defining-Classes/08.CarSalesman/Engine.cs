namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int enginePower;
        private int displacement;
        private string efficiency;

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }

        public int EnginePower
        {
            get { return enginePower; }
            set { this.enginePower = value; }
        }

        public int Displacement
        {
            get { return displacement; }
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { this.efficiency = value; }
        }

        public Engine(string model, int enginePower)
            : this(model, enginePower, 0, "n/a")
        {
        }

        public Engine(string model, int enginePower, int displacement, string efficiency)
        {
            this.model = model;
            this.enginePower = enginePower;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
    }
}