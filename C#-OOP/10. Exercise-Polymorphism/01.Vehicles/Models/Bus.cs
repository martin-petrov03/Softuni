namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private double airConditionalConsumption = 1.4;
        private double defaultFuelConsumption;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {         
            this.defaultFuelConsumption = fuelConsumption;
            this.airConditionalConsumption += fuelConsumption;
        }        

        public bool isEmpty { get; set; }

        public override bool Drive(double distance)
        {
            if (this.isEmpty)
            {
                this.FuelConsumption = this.airConditionalConsumption;
            }
            else
            {
                this.FuelConsumption = this.defaultFuelConsumption;
            }
            
            return base.Drive(distance);
        }
    }
}
