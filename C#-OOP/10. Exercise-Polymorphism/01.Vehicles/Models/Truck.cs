using System;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double AirConditionAdditionalConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += AirConditionAdditionalConsumption;
        }

        public double FuelConsumption { get; set; }

        public override void Refuel(double fuel)
        {
            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }

            fuel *= 0.95;

            base.Refuel(fuel);
        }
    }
}
