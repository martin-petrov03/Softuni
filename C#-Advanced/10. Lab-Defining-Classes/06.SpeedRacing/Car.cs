using System.Collections.Generic;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private int travelledDistance;

        public string Model
        {
            get { return this.model; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }
        }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumption;
        }

        public int DistanceTravelled
        {
            get { return this.travelledDistance; }
        }

        public bool Drive(int distance)
        {
            double reduce = fuelAmount - fuelConsumptionPerKilometer * distance;
            if (reduce >= 0)
            {
                fuelAmount = reduce;
                travelledDistance += distance;
                return true;
            }
            return false;
        }
    }
}