using System;
using System.Linq;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine()
                .Split()
                .ToArray();
            string[] truckInfo = Console.ReadLine()
                .Split()
                .ToArray();
            string[] busInfo = Console.ReadLine()
                .Split()
                .ToArray();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);


            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                try
                {
                    string[] line = Console.ReadLine()
                    .Split()
                    .ToArray();
                    string command = line[0];
                    string vehicleType = line[1];
                    double value = double.Parse(line[2]);

                    if (command == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            DriveVehicle(car, value);
                        }
                        else if (vehicleType == "Truck")
                        {
                            DriveVehicle(truck, value);
                        }
                        else if (vehicleType == "Bus")
                        {
                            bus.isEmpty = false;
                            DriveVehicle(bus, value);
                        }
                    }
                    else if (command == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(value);
                        }
                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(value);
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        bus.isEmpty = true;
                        DriveVehicle(bus, value);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }

        static void DriveVehicle(Vehicle vehicle, double value)
        {
            bool canTravell = vehicle.Drive(value);

            string result =
                !canTravell
                ? $"{vehicle.GetType().Name} needs refueling"
                : $"{vehicle.GetType().Name} travelled {value} km";

            Console.WriteLine(result);
        }
    }
}
