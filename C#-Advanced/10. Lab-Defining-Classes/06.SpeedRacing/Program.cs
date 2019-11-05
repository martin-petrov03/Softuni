using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] line = Console.ReadLine().Split();
                string carModel = line[0];
                double fuelAmount = double.Parse(line[1]);
                double fuelConsumptionPerKilometer = double.Parse(line[2]);

                if (cars.TrueForAll(c => c.Model != carModel))
                {
                    Car currentCar = new Car(carModel, fuelAmount, fuelConsumptionPerKilometer);
                    cars.Add(currentCar);
                }
                //currentCar.Model = carModel;
                //currentCar.FuelAmount= fuelAmount;
                //currentCar.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;

            }

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string model = input[1];
                int distance = int.Parse(input[2]);
                Car car = cars.First(c => c.Model == model);

                if (!car.Drive(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                input = Console.ReadLine().Split();
            }
            cars.ForEach(c => Console.WriteLine($"{c.Model} {c.FuelAmount:f2} {c.DistanceTravelled}"));
        }
    }
}