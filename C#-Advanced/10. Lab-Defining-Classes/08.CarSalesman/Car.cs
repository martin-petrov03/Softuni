namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { this.engine = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { this.color = value; }
        }

        public Car(string model, Engine engine)
            : this(model, engine, 0, "n/a")
        {
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }
    }
}